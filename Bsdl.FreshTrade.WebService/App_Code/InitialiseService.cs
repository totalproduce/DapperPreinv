using Autofac;
using Autofac.Integration.Wcf;
using Bsdl.FreshTrade.Repositories.Account.Accounts;
using Bsdl.FreshTrade.Repositories.Account.Customer;
using Bsdl.FreshTrade.Repositories.Account.GLInfo;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Account.SalesOffice;
using Bsdl.FreshTrade.Repositories.Basic.CurrencyRateRep;
using Bsdl.FreshTrade.Repositories.Basic.Dictionaries;
using Bsdl.FreshTrade.Repositories.Basic.ErrorLog;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.SysPreferencesRep;
using Bsdl.FreshTrade.Repositories.Basic.UserRepository;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Cache;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.DatabaseConnection;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.AccToProcess;
using Bsdl.FreshTrade.Repositories.PreInv.Audit;
using Bsdl.FreshTrade.Repositories.PreInv.BatchRep;
using Bsdl.FreshTrade.Repositories.PreInv.DeliveryRep;
using Bsdl.FreshTrade.Repositories.PreInv.DestinationRep;
using Bsdl.FreshTrade.Repositories.PreInv.DiscountRep;
using Bsdl.FreshTrade.Repositories.PreInv.EdiRep;
using Bsdl.FreshTrade.Repositories.PreInv.ErrorRep;
using Bsdl.FreshTrade.Repositories.PreInv.HeadOfficeRep;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.OrderRep;
using Bsdl.FreshTrade.Repositories.PreInv.PostTypeRep;
using Bsdl.FreshTrade.Repositories.PreInv.PriceListRep;
using Bsdl.FreshTrade.Repositories.PreInv.ProductRep;
using Bsdl.FreshTrade.Repositories.PreInv.ReChargeRep;
using Bsdl.FreshTrade.Repositories.PreInv.Reports;
using Bsdl.FreshTrade.Repositories.PreInv.Reports.Error;
using Bsdl.FreshTrade.Repositories.PreInv.Reports.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.StockRep;
using Bsdl.FreshTrade.Repositories.PreInv.TempRep;
using Bsdl.FreshTrade.Repositories.PreInv.VatRep;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Account.Accounts;
using Bsdl.FreshTrade.Services.Account.Customer;
using Bsdl.FreshTrade.Services.Account.SalesOffices;
using Bsdl.FreshTrade.Services.Basic.Dictionary;
using Bsdl.FreshTrade.Services.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic.Users;
using Bsdl.FreshTrade.Services.Basic.Utilities.Logs;
using Bsdl.FreshTrade.Services.PreInv.Interfaces;
using Bsdl.FreshTrade.Services.PreInv.Model;
using Bsdl.FreshTrade.Services.PreInv.Model.Interfaces;
using Bsdl.FreshTrade.Services.PreInv.Reports.Services;
using Bsdl.FreshTrade.Services.PreInv.Services;
using Bsdl.FreshTrade.Services.ReportingDX;
using Bsdl.FreshTrade.WebService.Utilities;

namespace Bsdl.FreshTrade.WebService.App_Code
{
    public class ServiceAppInitializer
    {
        public static void AppInitialize()
        {
            var builder = GetAutofacContainerBuilder();
            AutofacHostFactory.Container = builder.Build();
        }

        private static ContainerBuilder GetAutofacContainerBuilder()
        {
            var result = new ContainerBuilder();
            #region Services
            result.RegisterType<UserService>();
            result.RegisterType<AccountsService>();
            result.RegisterType<SalesOfficesService>();
            result.RegisterType<DictionaryService>(); // For WCF created instance
            result.RegisterType<DictionaryService>().As<IDictionaryService>(); // For IoC interservice created instance
            result.RegisterType<PreInvService>();
            result.RegisterType<PreInvService>().As<IPreInvService>();
            result.RegisterType<PreInvReportService>();
            result.RegisterType<CustomerService>();
            result.RegisterType<ReportingService>();

            #endregion
            #region Repositories
            result.RegisterType<UserRepository>().As<IUserRepository>();
            result.RegisterType<UserToSalesOfficeRepository>().As<IUserToSalesOfficeRepository>();            
            result.RegisterType<DapperErrorLogRepository>().As<IErrorLogRepository>();
            // Account Repository
            result.RegisterType<SalesOfficeRepository>().As<ISalesOfficeRepository>();
            result.RegisterType<CustomerGroupRepository>().As<ICustomerGroupRepository>();
            result.RegisterType<CustomerCategoryRepository>().As<ICustomerCategoryRepository>();
            result.RegisterType<ErrorDescriptionRepository>().As<IErrorDescriptionRepository>();
            result.RegisterType<SystemPreferenceRepository>().As<ISystemPreferenceRepository>();

            result.RegisterType<DapperCompanyDicitonaryRepository>().As<ICompanyDictionaryRepository>();
            result.RegisterType<DapperCurrencyDicitonaryRepository>().As<ICurrencyDictionaryRepository>();
            result.RegisterType<SalesPersonRepository>().As<ISalesPersonRepository>();
            result.RegisterType<AccountRepository>().As<IAccountRepository>();
            result.RegisterType<AccountClassRepository>().As<IAccountClassRepository>();
            result.RegisterType<CustomerCategoryDepencencyRepository>().As<ICustomerCategoryDepencencyRepository>();
            result.RegisterType<AccToProcessRepository>().As<IAccToProcessRepository>();
            result.RegisterType<HeadOfficeRepository>().As<IHeadOfficeRepository>();
            result.RegisterType<GLBrakedOnRepository>().As<IGLInfoRepository>();
            result.RegisterType<PriceGroupRepository>().As<IPriceGroupRepository>();
            result.RegisterType<OrderRepository>().As<IOrderRepository>();
            result.RegisterType<DeliveryHeadRepository>().As<IDeliveryHeadRepository>();
            result.RegisterType<DeliveryDetailRepository>().As<IDeliveryDetailRepository>();
            result.RegisterType<DeliveryTypeRepository>().As<IDeliveryTypeRepository>();
            result.RegisterType<DeliveryPriceRepository>().As<IDeliveryPriceRepository>();
            result.RegisterType<DeliveryToItemStockRepository>().As<IDeliveryToItemStockRepository>();
            result.RegisterType<DeliveryPriceToCreditNoteRepository>().As<IDeliveryPriceToCreditNoteRepository>();
            result.RegisterType<ProductRepository>().As<IProductRepository>();
            result.RegisterType<StockLocationRepository>().As<IStockLocationRepository>();
            result.RegisterType<VatLinkRepository>().As<IVatLinkRepository>();
            result.RegisterType<VatRateRepository>().As<IVatRateRepository>();
            result.RegisterType<CustomerProductInfoRepository>().As<ICustomerProductInfoRepository>();
            result.RegisterType<CurrencyRateRepository>().As<ICurrencyRateRepository>();
            result.RegisterType<EdiCoSuppNoRepository>().As<IEdiCoSuppNoRepository>();
            result.RegisterType<PriceListVatCheckRepository>().As<IPriceListVatCheckRepository>();
            result.RegisterType<CustomerDiscountRatesRepository>().As<ICustomerDiscountRatesRepository>();
            result.RegisterType<DiscountRatesRepository>().As<IDiscountRatesRepository>();
            result.RegisterType<ProductTranslationRepository>().As<IProductTranslationRepository>();

            //preinv transient repositories
            result.RegisterType<PreInvTotRepository>().As<IPreInvTotRepository>();
            result.RegisterType<PreINVPRTRepository>().As<IPreINVPRTRepository>();
            result.RegisterType<PreInvPrt2Repository>().As<IPreInvPrt2Repository>();

            result.RegisterType<InvTotRepository>().As<IInvTotRepository>();
            result.RegisterType<InvDiscTypRepository>().As<IInvDiscTypRepository>();
            result.RegisterType<INVEDIRepository>().As<IINVEDIRepository>();
            result.RegisterType<InvErrRepository>().As<IInvErrRepository>();
            result.RegisterType<INVPRTRepository>().As<IINVPRTRepository>();
            result.RegisterType<InvPrt2Repository>().As<IInvPrt2Repository>();
            result.RegisterType<InvExtractHedRepository>().As<IInvExtractHedRepository>();
            //destination repository
            result.RegisterType<AccAllocRepositoryRepository>().As<IAccAllocRepository>();
            result.RegisterType<AccAllValRepository>().As<IAccAllValRepository>();
            result.RegisterType<AcciteRepository>().As<IAcciteRepository>();
            result.RegisterType<AccTrnFilRepository>().As<IAccTrnFilRepository>();
            result.RegisterType<AccVATRepository>().As<IAccVATRepository>();
            result.RegisterType<EdiInvRepository>().As<IEdiInvRepository>();
            result.RegisterType<EdiLogInvoiceRepository>().As<IEdiLogInvoiceRepository>();
            result.RegisterType<ExpChaRepository>().As<IExpChaRepository>();
            result.RegisterType<GLTransRepository>().As<IGLTransRepository>();
            result.RegisterType<IteChgRepository>().As<IIteChgRepository>();
            result.RegisterType<PostTypeRepository>().As<IPostTypeRepository>();
            result.RegisterType<AccReChgRepository>().As<IAccReChgRepository>();
            result.RegisterType<BatchRepository>().As<IBatchRepository>();
            result.RegisterType<BatchDetRepository>().As<IBatchDetRepository>();
            result.RegisterType<AuditRecordRepository>().As<IAuditRecordRepository>();
            result.RegisterType<DelAuditRecordRepository>().As<IDelAuditRecordRepository>();
            result.RegisterType<DelAudToDoRecordRepository>().As<IDelAudToDoRecordRepository>();
            result.RegisterType<IchDiscTypRepository>().As<IIchDiscTypRepository>();
            
            //reports
            result.RegisterType<ErrorReportRepository>().As<IErrorReportRepository>();
            result.RegisterType<SummaryReportRepository>().As<ISummaryReportRepository>();
            result.RegisterType<DetailReportRepository>().As<IDetailReportRepository>();

            //mocked repositories
            //result.RegisterType<MockAccountRepository>().As<IAccountRepository>();
            //result.RegisterType<MockCompanyDictionaryRepository>().As<ICompanyDictionaryRepository>();
            //result.RegisterType<MockCurrencyDictionaryRepository>().As<ICurrencyDictionaryRepository>();
            //result.RegisterType<MockSalesOfficeRepository>().As<ISalesOfficeRepository>();
            #endregion
            #region Helpers
            result.RegisterType<EventsLogger>().As<IEventsLogger>().InstancePerLifetimeScope();
            result.RegisterType<CacheManagerFactory>().As<ICacheManagerFactory>().InstancePerLifetimeScope();
            
            result.Register(c => { return DatabaseConnectionPool.Instance; }).As<IDatabaseConnectionPool>();
            result.RegisterType<RepositoryFactory>().As<IRepositoryFactory>();
            result.RegisterType<ExtractionProcessor>().As<IExtractionProcessor>();             
            #endregion

            result.RegisterType<ExtractionProcessorFactory>().As<IExtractionProcessorFactory>().InstancePerLifetimeScope();

            return result;
        }

    }
}
