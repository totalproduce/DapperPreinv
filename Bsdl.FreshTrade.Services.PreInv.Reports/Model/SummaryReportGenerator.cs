using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Reports.Interfaces;

namespace Bsdl.FreshTrade.Services.PreInv.Reports.Model
{
    public class SummaryReportGenerator: ReportGeneratorBase
    {
        private const string _reportName = "SummaryReport";
        private const string _resultHeaderName = "Header";
        private const string _resultDataName = "InvTot";

        public List<WideSummaryReportItem> DataPostProcessing(List<WideSummaryReportItem> data)
        {
            foreach (var item in data)
            {
                item.BatchTypeAsStr = ((PreInvBatchType)item.BatchType).ConvertToString();
                item.InvoiceTypeAsStr = ((PreInvInvoiceType)item.InvoiceType).ConvertToString();
            }
            return data.OrderBy(sr => sr.HofCstCode).ToList();
        }

        public override bool IsReportTypeSupported(string reportType)
        {
            return reportType == _reportName;
        }

        public override List<DataTable> GenerateReport(IUnitOfWork unitOfWorkCurrent, int extractSessionID, string reportType, Dictionary<string, string> reportParams)
        {
            if (reportType != _reportName)
            {
                return null;
            }

            var invExtractHedRepository = unitOfWorkCurrent.GetRepository<IInvExtractHedRepository>();
            var summaryReportRepository = unitOfWorkCurrent.GetRepository<ISummaryReportRepository>();

            return new List<DataTable>(2)
                             {
                                 BuildDataTable(_resultHeaderName, invExtractHedRepository.GetInvExtractHeadByExtractionSessionId(extractSessionID)),
                                 BuildDataTable(_resultDataName, typeof(WideSummaryReportItem), DataPostProcessing(summaryReportRepository.GetByExtractSessionID(extractSessionID)))
                             };
        }

    }
}
