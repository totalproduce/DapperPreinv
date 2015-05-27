using System.Data;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.Domain.PreInv.Utilities.SessionContext;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Reports.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic;
using Bsdl.FreshTrade.Services.PreInv.Reports.Interfaces;
using System.Collections.Generic;
using Bsdl.FreshTrade.Services.PreInv.Reports.Model;

namespace Bsdl.FreshTrade.Services.PreInv.Reports.Services
{
    public class PreInvReportService : FreshTradeServiceBase, IPreInvReportService
    {
        private readonly IEnumerable<ReportGeneratorBase> _reportGenerators = new List<ReportGeneratorBase>()
                                                                                  {
                                                                                      new ErrorReportGenerator(),
                                                                                      new SummaryReportGenerator(),
                                                                                      new DetailReportGenerator()
                                                                                  };

        #region Helpers

        private int GetExtractSessionID()
        {
            if (string.IsNullOrEmpty(GetUserSessionID()))
            {
                //throw new FreshTradeException("userSessionID cannot be empty");
                return -1;
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
                preinvSession = (PreInvSessionContext) preinvSessionRaw;
            }
            if ((preinvSession == null) || !preinvSession.ExtractSessionID.HasValue)
            {
                throw new FreshTradeException(
                    "Extraction session is not initialized or timed out. Please reextract data and try again.");
            }
            return preinvSession.ExtractSessionID.Value;
        }

        #endregion

        public PreInvReportService(IRepositoryFactory repositoryFactory)
            : base(repositoryFactory)
        {
        }

        public List<DataTable> GenerateReport(string reportName, Dictionary<string, string> reportParams)
        {
            foreach (var reportGenerator in _reportGenerators)
            {
                if (reportGenerator.IsReportTypeSupported(reportName))
                {
                    return reportGenerator.GenerateReport(UnitOfWorkCurrent, GetExtractSessionID(), reportName, reportParams);
                }
            }
            throw new FreshTradeException(string.Format("Report '{0}' is not supported", reportName));
        }
    }
}
