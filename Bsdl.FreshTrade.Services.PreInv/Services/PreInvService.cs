using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using AutoMapper;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Domain.PreInv.Utilities.SessionContext;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Reports.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic;
using Bsdl.FreshTrade.Services.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic.Utilities.SessionContext;
using Bsdl.FreshTrade.Services.PreInv.Interfaces;
using Bsdl.FreshTrade.Services.PreInv.Mappings;
using Bsdl.FreshTrade.Services.PreInv.Model;
using Bsdl.FreshTrade.Services.PreInv.Model.Interfaces;
using Bsdl.FreshTrade.Services.PreInv.Model.Reports;

namespace Bsdl.FreshTrade.Services.PreInv.Services
{
    public class PreInvService : FreshTradeServiceBase, IPreInvService
    {
        #region Repositories

        private ISalesOfficeRepository _salesOfficeRepository;
        protected ISalesOfficeRepository SalesOfficeRepository
        {
            get
            {
                return _salesOfficeRepository
                       ?? (_salesOfficeRepository = UnitOfWorkCurrent.GetRepository<ISalesOfficeRepository>());
            }
        }

        private ICurrencyDictionaryRepository _currencyDictionaryRepository;
        protected ICurrencyDictionaryRepository CurrencyDictionaryRepository
        {
            get
            {
                return _currencyDictionaryRepository
                       ?? (_currencyDictionaryRepository =
                           UnitOfWorkCurrent.GetRepository<ICurrencyDictionaryRepository>());
            }
        }

        private ICompanyDictionaryRepository _companyDictionaryRepository;
        protected ICompanyDictionaryRepository CompanyDictionaryRepository
        {
            get
            {
                return _companyDictionaryRepository
                       ?? (_companyDictionaryRepository =
                           UnitOfWorkCurrent.GetRepository<ICompanyDictionaryRepository>());
            }
        }

        private ISystemPreferenceRepository _systemPreferenceRepository;
        protected ISystemPreferenceRepository SystemPreferenceRepository
        {
            get
            {
                return _systemPreferenceRepository
                       ?? (_systemPreferenceRepository =
                           UnitOfWorkCurrent.GetRepository<ISystemPreferenceRepository>());
            }
        }

        
        #endregion

        #region Services
        private IDictionaryService _dictionaryService;
        #endregion

        #region Helpers

        private const string _settingsCacheKey = "PreInvSettings";
        private const string _formName = "PREINV";


        private object _settingsReadLock = new object();

        private SystemPreferences _sysPreferences;
        protected SystemPreferences SysPreferences
        {
            get
            {
                if (_sysPreferences == null)
                {
                    lock (_settingsReadLock)
                    {
                        if (_sysPreferences == null)
                        {
                            Thread.MemoryBarrier();
                            var cacheManager = _cacheManagerFactory.Get(CachingStrategy.GlobalCache);
                            string cacheKey = UserDbID.ToString() + _settingsCacheKey;
                            _sysPreferences = (SystemPreferences)cacheManager.Get(cacheKey);
                            if (_sysPreferences == null)
                            {
                                var settingList =
                                    SystemPreferenceRepository.GetSettings(SystemPreferences.GetSettingNames(), _formName);
                                _sysPreferences = SystemPreferences.ReadFromSettingList(settingList, SystemPreferenceRepository.SettingsKeyFormName, SystemPreferenceRepository.SettingsKeyFormNo);
                                cacheManager.Set(cacheKey, _sysPreferences);
                            }
                        }
                    }
                }
                return _sysPreferences;
            }
        }

        private ICacheManagerFactory _cacheManagerFactory;
            
           /* =
            new SystemPreferences //TODO: READ NEEDED PREFERENCES HERE
            {
                UseAlternativeProductGroups = false,
                TransShipmentAuthFlag = 0,
                UseShipDate = false,
                UserHasVat = true,
                NeedsPriceListVatCheck = false,
                UseDelivDate = true,
                AddSoToInvNo = false,
                AddYearToInvNo = false,
                IsSandardUnitsRequered = false,
                ProductAnalysisLevNo = 1,
                DebitsGreaterInPreinv = true,
                PreInvSortKey1 = "HEAD OFFICE",
                PreInvSortKey2 = "CUSTOMER",
                InvPrtSortKey1 = string.Empty,
                StandardUnitsRequired = false,
                StandardUnitsLevel = 1,
                CheckForNonReleasedCredits = true
            };*/
        private const string _preInvSquence_UserSessionID = "PREINVTEMP_UserSessionID";

        private IExtractionProcessor _extractionProcessor;

        private void InitializeExtractionSession(DTOPreInvExtractParams extractParams)
        {
            InMemorySessionContextStorage.UpdateSessionContext(GetUserSessionID(), (object sessionData) =>
            {
                var context = (SessionContext)sessionData;
                object preInvSessionContextAsObj;
                PreInvSessionContext preInvSessionContext;
                if (context.Data.TryGetValue(PreInvSessionContext.PreInvSessionName, out preInvSessionContextAsObj))
                {
                    preInvSessionContext = (PreInvSessionContext) preInvSessionContextAsObj;
                }
                else
                {
                    preInvSessionContext = new PreInvSessionContext
                    {
                        ExtractSessionID = (int)(UnitOfWorkCurrent.GenNextSequenceID(_preInvSquence_UserSessionID))
                    };
                }
                preInvSessionContext.SalesOfficeNo = extractParams.SalesOfficeNo;
                context.Data[PreInvSessionContext.PreInvSessionName] = preInvSessionContext;
            });
        }
        #endregion

        public PreInvService(IRepositoryFactory repositoryFactory, IDictionaryService dictionaryService, IExtractionProcessorFactory extractionProcessorFactory, ICacheManagerFactory cacheManagerFactory)
            : base(repositoryFactory)
        {
            _dictionaryService = dictionaryService;
            _dictionaryService.AssignUnitOfWork(UnitOfWorkCurrent);
            _cacheManagerFactory = cacheManagerFactory;
            _extractionProcessor = extractionProcessorFactory.GetProcessor(SysPreferences, UnitOfWorkCurrent, _dictionaryService);
            _extractionProcessor.SetProgressWatcher(UpdateProgressDelegate);
        }

        private void UpdateProgressDelegate(int percentage)
        {
            InMemorySessionContextStorage.UpdateSessionContext(GetUserSessionID(), (object sessionData) =>
            {
                var context = (SessionContext)sessionData;
                ((PreInvSessionContext)context.Data[PreInvSessionContext.PreInvSessionName]).ExtractionPercentage = percentage;
            });
        }

        public DTOPreInvExtractResult Extract(DTOPreInvExtractParams extractParams)
    {
            CleanUp();
            InitializeExtractionSession(extractParams);
            var paramsValidator = new ExtractionParametersValidator
                (
                    SalesOfficeRepository,
                    CurrencyDictionaryRepository,
                    CompanyDictionaryRepository
                );
            paramsValidator.Validate(extractParams);


            var exractionSessionId = ((PreInvSessionContext) UserSessionContext.Data[PreInvSessionContext.PreInvSessionName]).ExtractSessionID;
            if (!exractionSessionId.HasValue)
            {
                throw new FreshTradeException("Extraction Session is not initialized");
            }
            return _extractionProcessor.Process(extractParams, exractionSessionId.Value, UserSessionContext.FreshTradeUser);
        }

        public int? GetProgress()
        {
            object sessionContext = null;
            if (UserSessionContext.Data.TryGetValue(PreInvSessionContext.PreInvSessionName, out sessionContext))
            {
                return ((PreInvSessionContext) sessionContext).ExtractionPercentage;
            }
            return null;
        }

        public Dictionary<string, string> PrepareForPrint(DTOPreInvUpdateParams updateParams)
        {
            var preInvSessionContext = ((PreInvSessionContext)UserSessionContext.Data[PreInvSessionContext.PreInvSessionName]);
            if ((preInvSessionContext == null) || !preInvSessionContext.ExtractSessionID.HasValue)
            {
                throw new FreshTradeException("Extraction Session is not initialized");
            }

            var preparePrintProcessor = new PreparePrintProcessor(SysPreferences, UnitOfWorkCurrent, _dictionaryService);

            return preparePrintProcessor.Process(updateParams, preInvSessionContext.ExtractSessionID.Value);
        }

        public PreInvUpdateStatusType Update(DTOPreInvUpdateParams updateParams)
        {
            var preInvSessionContext = ((PreInvSessionContext) UserSessionContext.Data[PreInvSessionContext.PreInvSessionName]);
            if ((preInvSessionContext == null) || !preInvSessionContext.ExtractSessionID.HasValue)
            {
                throw new FreshTradeException("Extraction Session is not initialized");
            }

            var updateProcessor = new UpdateProcessor(SysPreferences, UnitOfWorkCurrent, UserSessionContext.FreshTradeUser);
          updateProcessor.ProgressChanged += UpdateProgressDelegate;

            return updateProcessor.Update(updateParams, preInvSessionContext.ExtractSessionID.Value);
        }

        public void CleanUp()
        {
            object preinvSessionAsObj;
            if (UserSessionContext.Data.TryGetValue(PreInvSessionContext.PreInvSessionName, out preinvSessionAsObj))
            {
                var preinvSession = (PreInvSessionContext)preinvSessionAsObj;
                if (preinvSession != null)
                {
                    _extractionProcessor.CleanUp(preinvSession.SalesOfficeNo, preinvSession.ExtractSessionID);
                }
            }
        }


        public string GetExportData(DTOPreInvUpdateParams updateParams)
        {
            var ret = ((PreInvSessionContext) UserSessionContext.Data[PreInvSessionContext.PreInvSessionName]).ExtractSessionID;
            if (ret != null)
                return new DataExportProcessor(UnitOfWorkCurrent).Process(updateParams,
                    ret.Value);
            return null;
        }

        #region Helpers

        private int GetExtractSessionID()
        {
            if (string.IsNullOrEmpty(GetUserSessionID()))
            {
                throw new FreshTradeException("userSessionID cannot be empty");
            }
            PreInvSessionContext preinvSession = null;
            object preinvSessionRaw;
            if ((UserSessionContext == null) || (UserSessionContext.Data == null))
            {
                throw new FreshTradeException(
                    "User session is not initialized or timed out. Please reextract data and try again.");
            }
            if (UserSessionContext.Data.TryGetValue(PreInvSessionContext.PreInvSessionName, out preinvSessionRaw))
            {
                preinvSession = (PreInvSessionContext)preinvSessionRaw;
            }
            if ((preinvSession == null) || !preinvSession.ExtractSessionID.HasValue)
            {
                throw new FreshTradeException(
                    "Extraction session is not initialized or timed out. Please reextract data and try again.");
            }
            return preinvSession.ExtractSessionID.Value;
        }

        #endregion

        #region Report Data Retrieve methods
        public object GetErrorsReportData(Dictionary<string, string> parameters)
        {
            var extractSessionID = GetExtractSessionID();
            var invErrRepository = UnitOfWorkCurrent.GetRepository<IErrorReportRepository>();

            Mapper.Initialize(cfg => cfg.AddProfile<EntitytoReportMap>());

            return new
            {
                ExtractHeader = Mapper.Map<PreInvExtractHeader>(UnitOfWorkCurrent.GetRepository<IInvExtractHedRepository>().GetInvExtractHeadByExtractionSessionId(extractSessionID)),
                Errors = Mapper.Map<List<PreInvExtractionErrorsItem>>(invErrRepository.GetByExtractSessionID(extractSessionID))
            };
        }

        public object GetSummaryReportData(Dictionary<string, string> parameters)
        {
            var extractSessionID = GetExtractSessionID();
            var summaryReportRepository = UnitOfWorkCurrent.GetRepository<ISummaryReportRepository>();
            var invTotSrc = summaryReportRepository.GetByExtractSessionID(extractSessionID);

            Mapper.Initialize(cfg => cfg.AddProfile<EntitytoReportMap>());

            var invTot = Mapper.Map<List<PreInvTot>>(invTotSrc);

            return new
            {
                ExtractHeader = Mapper.Map<PreInvExtractHeader>(UnitOfWorkCurrent.GetRepository<IInvExtractHedRepository>().GetInvExtractHeadByExtractionSessionId(extractSessionID)),
                InvTot = invTot
            };
        }

        public object GetDetailReportData(Dictionary<string, string> parameters)
        {
            var extractSessionID = GetExtractSessionID();
            var detailReportRepository = UnitOfWorkCurrent.GetRepository<IDetailReportRepository>();
            var invDetailSrc = detailReportRepository.GetByExtractSessionID(extractSessionID);

            Mapper.Initialize(cfg => cfg.AddProfile<EntitytoReportMap>());

            var invTots = Mapper.Map<List<PreInvTot>>(invDetailSrc)
                .GroupBy(t => t.InvoiceNo).Select(g => g.First()).ToList();

            var invPrts = Mapper.Map<List<PreInvPrt>>(invDetailSrc)
                .GroupBy(t => new { t.DlvOrdNo, t.DlvInvoiceNo }).Select(g => g.First()).ToList();
            var invPrt2S = Mapper.Map<List<PreInvPrt2>>(invDetailSrc);

            var resTotList = new List<object>();
            foreach (var invTot in invTots)
            {
                var resPrtList = new List<object>();
                foreach (var invPrt in invPrts.Where(p => p.DlvInvoiceNo == invTot.InvoiceNo))
                {
                    resPrtList.Add
                        (new
                        {
                            InvPrt = invPrt,
                            InvPrt2List = invPrt2S.Where(p2 => p2.DeliveryHead.Id == invPrt.DlvOrdNo && p2.InvoiceNo == invPrt.DlvInvoiceNo).ToList()
                        }
                        );
                }

                resTotList.Add
                    (
                        new
                        {
                            InvTot = invTot,
                            InvPrtList = resPrtList
                        }
                    );
            }

            var extractHead =
                Mapper.Map<PreInvExtractHeader>(
                    UnitOfWorkCurrent.GetRepository<IInvExtractHedRepository>()
                        .GetInvExtractHeadByExtractionSessionId(extractSessionID));

            return new
            {
                ExtractHeader = extractHead,
                InvTotList = resTotList
            };
        }

        #endregion
    }
}
