﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bsdl.FreshTrade.UI.Basic.DictionaryServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DictionaryServiceReference.IDictionaryService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IDictionaryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetCompanyData", ReplyAction="http://tempuri.org/IDictionaryService/GetCompanyDataResponse")]
        Bsdl.FreshTrade.Domain.Basic.Entities.DTOCompany[] GetCompanyData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetCurrencyData", ReplyAction="http://tempuri.org/IDictionaryService/GetCurrencyDataResponse")]
        Bsdl.FreshTrade.Domain.Basic.Entities.DTOCurrency[] GetCurrencyData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetPrintServerUrl", ReplyAction="http://tempuri.org/IDictionaryService/GetPrintServerUrlResponse")]
        string GetPrintServerUrl();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDictionaryServiceChannel : Bsdl.FreshTrade.UI.Basic.DictionaryServiceReference.IDictionaryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DictionaryServiceClient : System.ServiceModel.ClientBase<Bsdl.FreshTrade.UI.Basic.DictionaryServiceReference.IDictionaryService>, Bsdl.FreshTrade.UI.Basic.DictionaryServiceReference.IDictionaryService {
        
        public DictionaryServiceClient() {
        }
        
        public DictionaryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DictionaryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DictionaryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DictionaryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Bsdl.FreshTrade.Domain.Basic.Entities.DTOCompany[] GetCompanyData() {
            return base.Channel.GetCompanyData();
        }
        
        public Bsdl.FreshTrade.Domain.Basic.Entities.DTOCurrency[] GetCurrencyData() {
            return base.Channel.GetCurrencyData();
        }
        
        public string GetPrintServerUrl() {
            return base.Channel.GetPrintServerUrl();
        }
    }
}
