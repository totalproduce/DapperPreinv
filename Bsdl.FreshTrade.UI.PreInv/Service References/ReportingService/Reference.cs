﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bsdl.FreshTrade.UI.PreInv.ReportingService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReportingService.IReportingService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IReportingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportingService/GetReport", ReplyAction="http://tempuri.org/IReportingService/GetReportResponse")]
        byte[] GetReport(string reportName, System.Collections.Generic.Dictionary<string, string> reportParams);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReportingServiceChannel : Bsdl.FreshTrade.UI.PreInv.ReportingService.IReportingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReportingServiceClient : System.ServiceModel.ClientBase<Bsdl.FreshTrade.UI.PreInv.ReportingService.IReportingService>, Bsdl.FreshTrade.UI.PreInv.ReportingService.IReportingService {
        
        public ReportingServiceClient() {
        }
        
        public ReportingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReportingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public byte[] GetReport(string reportName, System.Collections.Generic.Dictionary<string, string> reportParams) {
            return base.Channel.GetReport(reportName, reportParams);
        }
    }
}
