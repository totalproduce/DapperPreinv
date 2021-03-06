﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Reports.Interfaces;

namespace Bsdl.FreshTrade.Services.PreInv.Reports.Model
{
    public class ErrorReportGenerator : ReportGeneratorBase
    {
        private const string _reportName = "ErrorReport";
        private const string _resultHeaderName = "Header";
        private const string _resultDataName = "Errors";

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
            var errorReportRepository = unitOfWorkCurrent.GetRepository<IErrorReportRepository>();

            return new List<DataTable>(2)
                             {
                                 BuildDataTable(_resultHeaderName, invExtractHedRepository.GetInvExtractHeadByExtractionSessionId(extractSessionID)),
                                 BuildDataTable(_resultDataName, typeof(WideErrorReportItem), errorReportRepository.GetByExtractSessionID(extractSessionID))
                             };
        }
    }
}
