using System;
using System.Collections.Generic;
using System.IO;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic;
using Bsdl.FreshTrade.Services.ReportingDX.Interfaces;
using Bsdl.FreshTrade.Services.ReportingDX.Utilities;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;

namespace Bsdl.FreshTrade.Services.ReportingDX
{
    public class ReportingService : FreshTradeServiceBase, IReportingService
    {
        private readonly IReportsDataProvider _reportsDataProvider;
        private readonly IReportsConfigurationManager _reportsConfigurationManager;

        public ReportingService(IRepositoryFactory repositoryFactory)
            : base(repositoryFactory)
        {
            _reportsDataProvider = new ReportsDataProvider();
            _reportsConfigurationManager = new ReportsConfigurationManager();
        }

        //public ReportingService(IExecutionContextRepository executionContextRepository, IReportsDataProvider reportsDataProvider, IReportsConfigurationManager reportsConfigurationManager)
        //    : base(executionContextRepository)
        //{
        //    _reportsDataProvider = reportsDataProvider;
        //    _reportsConfigurationManager = reportsConfigurationManager;
        //}

        protected class DataItem
        {
            public IEnumerable<object> ExtractHeader { get; set; }
            public IEnumerable<object> Errors { get; set; }
        }

        public byte[] GetReport(string reportName, Dictionary<string, string> reportParams)
        {
            var reportConfiguration = _reportsConfigurationManager.GetReportConfiguration(reportName);
            var data = _reportsDataProvider.GetData(reportConfiguration, reportParams);

            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, reportConfiguration.ReportTemplete);
            var report = XtraReport.FromFile(templatePath, true);

            report.DataSource = new List<object> {data};

            report.CreateDocument();
            using (var buff = new MemoryStream())
            {
                report.PrintingSystem.SaveDocument(buff);

                return buff.ToArray();
            }
        }
    }
}
