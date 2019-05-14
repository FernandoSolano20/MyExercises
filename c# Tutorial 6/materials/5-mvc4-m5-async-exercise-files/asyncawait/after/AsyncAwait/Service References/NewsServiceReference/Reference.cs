﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsyncAwait.NewsServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NewsServiceReference.INewsService")]
    public interface INewsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetHeadline", ReplyAction="http://tempuri.org/INewsService/GetHeadlineResponse")]
        string GetHeadline();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetHeadline", ReplyAction="http://tempuri.org/INewsService/GetHeadlineResponse")]
        System.Threading.Tasks.Task<string> GetHeadlineAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INewsServiceChannel : AsyncAwait.NewsServiceReference.INewsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NewsServiceClient : System.ServiceModel.ClientBase<AsyncAwait.NewsServiceReference.INewsService>, AsyncAwait.NewsServiceReference.INewsService {
        
        public NewsServiceClient() {
        }
        
        public NewsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NewsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetHeadline() {
            return base.Channel.GetHeadline();
        }
        
        public System.Threading.Tasks.Task<string> GetHeadlineAsync() {
            return base.Channel.GetHeadlineAsync();
        }
    }
}
