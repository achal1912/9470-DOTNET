﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TstWebWcf.MyWcfService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyWcfService.ITstSI")]
    public interface ITstSI {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITstSI/CalculateSI", ReplyAction="http://tempuri.org/ITstSI/CalculateSIResponse")]
        int CalculateSI(int p, int r, int t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITstSI/CalculateSI", ReplyAction="http://tempuri.org/ITstSI/CalculateSIResponse")]
        System.Threading.Tasks.Task<int> CalculateSIAsync(int p, int r, int t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITstSI/GetRecordList", ReplyAction="http://tempuri.org/ITstSI/GetRecordListResponse")]
        System.Data.DataTable GetRecordList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITstSI/GetRecordList", ReplyAction="http://tempuri.org/ITstSI/GetRecordListResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetRecordListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITstSIChannel : TstWebWcf.MyWcfService.ITstSI, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TstSIClient : System.ServiceModel.ClientBase<TstWebWcf.MyWcfService.ITstSI>, TstWebWcf.MyWcfService.ITstSI {
        
        public TstSIClient() {
        }
        
        public TstSIClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TstSIClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TstSIClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TstSIClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CalculateSI(int p, int r, int t) {
            return base.Channel.CalculateSI(p, r, t);
        }
        
        public System.Threading.Tasks.Task<int> CalculateSIAsync(int p, int r, int t) {
            return base.Channel.CalculateSIAsync(p, r, t);
        }
        
        public System.Data.DataTable GetRecordList() {
            return base.Channel.GetRecordList();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetRecordListAsync() {
            return base.Channel.GetRecordListAsync();
        }
    }
}
