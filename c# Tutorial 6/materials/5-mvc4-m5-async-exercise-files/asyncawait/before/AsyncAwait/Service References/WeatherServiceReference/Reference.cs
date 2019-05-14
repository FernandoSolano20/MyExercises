﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsyncAwait.WeatherServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeatherServiceReference.IWeatherService")]
    public interface IWeatherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/GetCurrentTemperature", ReplyAction="http://tempuri.org/IWeatherService/GetCurrentTemperatureResponse")]
        double GetCurrentTemperature();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWeatherService/GetCurrentTemperature", ReplyAction="http://tempuri.org/IWeatherService/GetCurrentTemperatureResponse")]
        System.IAsyncResult BeginGetCurrentTemperature(System.AsyncCallback callback, object asyncState);
        
        double EndGetCurrentTemperature(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherServiceChannel : AsyncAwait.WeatherServiceReference.IWeatherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCurrentTemperatureCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCurrentTemperatureCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public double Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherServiceClient : System.ServiceModel.ClientBase<AsyncAwait.WeatherServiceReference.IWeatherService>, AsyncAwait.WeatherServiceReference.IWeatherService {
        
        private BeginOperationDelegate onBeginGetCurrentTemperatureDelegate;
        
        private EndOperationDelegate onEndGetCurrentTemperatureDelegate;
        
        private System.Threading.SendOrPostCallback onGetCurrentTemperatureCompletedDelegate;
        
        public WeatherServiceClient() {
        }
        
        public WeatherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetCurrentTemperatureCompletedEventArgs> GetCurrentTemperatureCompleted;
        
        public double GetCurrentTemperature() {
            return base.Channel.GetCurrentTemperature();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetCurrentTemperature(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetCurrentTemperature(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public double EndGetCurrentTemperature(System.IAsyncResult result) {
            return base.Channel.EndGetCurrentTemperature(result);
        }
        
        private System.IAsyncResult OnBeginGetCurrentTemperature(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetCurrentTemperature(callback, asyncState);
        }
        
        private object[] OnEndGetCurrentTemperature(System.IAsyncResult result) {
            double retVal = this.EndGetCurrentTemperature(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCurrentTemperatureCompleted(object state) {
            if ((this.GetCurrentTemperatureCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCurrentTemperatureCompleted(this, new GetCurrentTemperatureCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetCurrentTemperatureAsync() {
            this.GetCurrentTemperatureAsync(null);
        }
        
        public void GetCurrentTemperatureAsync(object userState) {
            if ((this.onBeginGetCurrentTemperatureDelegate == null)) {
                this.onBeginGetCurrentTemperatureDelegate = new BeginOperationDelegate(this.OnBeginGetCurrentTemperature);
            }
            if ((this.onEndGetCurrentTemperatureDelegate == null)) {
                this.onEndGetCurrentTemperatureDelegate = new EndOperationDelegate(this.OnEndGetCurrentTemperature);
            }
            if ((this.onGetCurrentTemperatureCompletedDelegate == null)) {
                this.onGetCurrentTemperatureCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCurrentTemperatureCompleted);
            }
            base.InvokeAsync(this.onBeginGetCurrentTemperatureDelegate, null, this.onEndGetCurrentTemperatureDelegate, this.onGetCurrentTemperatureCompletedDelegate, userState);
        }
    }
}