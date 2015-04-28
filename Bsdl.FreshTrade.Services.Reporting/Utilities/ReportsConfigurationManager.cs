using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Services.ReportingDX.Interfaces;

namespace Bsdl.FreshTrade.Services.ReportingDX.Utilities
{
    public class ReportsConfigurationManager : IReportsConfigurationManager
    {
        private const string _reportConfigurationFileSettingKey = "ReportConfigurationFile";
        private readonly Dictionary<string, ReportConfiguration> _reportsConfigurations;

        private IEnumerable<ReportConfiguration> ReadFromConfigurationFile(string fileName)
        {
            var result = new List<ReportConfiguration>();
            var document = new XmlDocument();
            var file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            try
            {
                document.Load(file);
            }
            finally
            {
                file.Close();
            }
            var nodes = document.SelectNodes(@"/reports/report");
            if (nodes != null)
            {
                foreach (var xmlItem in nodes)
                {
                    var element = xmlItem as XmlElement;
                    if (element == null)
                    {
                        continue;
                    }
                    result.Add
                        (
                            new ReportConfiguration
                            {
                                Name = element.GetAttribute("name"),
                                ServiceName = element.GetAttribute("dataservice"),
                                MethodName = element.GetAttribute("datamethod"),
                                ReportTemplete = element.GetAttribute("template")
                            }
                        );
                }
            }

            return result;
        }

        public ReportsConfigurationManager()
        {
            string configFilePath = ConfigurationManager.AppSettings[_reportConfigurationFileSettingKey];
            if (string.IsNullOrWhiteSpace(configFilePath))
            {
                throw new FreshTradeException("Report configuration file is not specified");
            }
            _reportsConfigurations = ReadFromConfigurationFile(configFilePath).ToDictionary(x => x.Name, x => x);
        }

        public ReportConfiguration GetReportConfiguration(string reportName)
        {
            ReportConfiguration result;
            if (!_reportsConfigurations.TryGetValue(reportName, out result))
            {
                throw new FreshTradeException(string.Format("Report '{0}' has no declaration in reports configuration", reportName));
            }
            return result;
        }
    }
}
