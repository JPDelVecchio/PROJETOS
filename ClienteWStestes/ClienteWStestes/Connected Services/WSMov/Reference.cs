﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWStestes.WSMov {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.totvs.com/", ConfigurationName="WSMov.IRMSServer")]
    public interface IRMSServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        bool Implements(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        bool CheckServiceActivity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        System.Threading.Tasks.Task<bool> CheckServiceActivityAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRMSServerChannel : ClienteWStestes.WSMov.IRMSServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RMSServerClient : System.ServiceModel.ClientBase<ClienteWStestes.WSMov.IRMSServer>, ClienteWStestes.WSMov.IRMSServer {
        
        public RMSServerClient() {
        }
        
        public RMSServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RMSServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RMSServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RMSServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Implements(System.Type type) {
            return base.Channel.Implements(type);
        }
        
        public System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type) {
            return base.Channel.ImplementsAsync(type);
        }
        
        public bool CheckServiceActivity() {
            return base.Channel.CheckServiceActivity();
        }
        
        public System.Threading.Tasks.Task<bool> CheckServiceActivityAsync() {
            return base.Channel.CheckServiceActivityAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.totvs.com/", ConfigurationName="WSMov.IwsBase")]
    public interface IwsBase {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        bool Implements(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        bool CheckServiceActivity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        System.Threading.Tasks.Task<bool> CheckServiceActivityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsBase/AutenticaAcesso", ReplyAction="http://www.totvs.com/IwsBase/AutenticaAcessoResponse")]
        string AutenticaAcesso();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsBase/AutenticaAcesso", ReplyAction="http://www.totvs.com/IwsBase/AutenticaAcessoResponse")]
        System.Threading.Tasks.Task<string> AutenticaAcessoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwsBaseChannel : ClienteWStestes.WSMov.IwsBase, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwsBaseClient : System.ServiceModel.ClientBase<ClienteWStestes.WSMov.IwsBase>, ClienteWStestes.WSMov.IwsBase {
        
        public IwsBaseClient() {
        }
        
        public IwsBaseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IwsBaseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsBaseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsBaseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Implements(System.Type type) {
            return base.Channel.Implements(type);
        }
        
        public System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type) {
            return base.Channel.ImplementsAsync(type);
        }
        
        public bool CheckServiceActivity() {
            return base.Channel.CheckServiceActivity();
        }
        
        public System.Threading.Tasks.Task<bool> CheckServiceActivityAsync() {
            return base.Channel.CheckServiceActivityAsync();
        }
        
        public string AutenticaAcesso() {
            return base.Channel.AutenticaAcesso();
        }
        
        public System.Threading.Tasks.Task<string> AutenticaAcessoAsync() {
            return base.Channel.AutenticaAcessoAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.totvs.com/", ConfigurationName="WSMov.IwsMov")]
    public interface IwsMov {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        bool Implements(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        bool CheckServiceActivity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        System.Threading.Tasks.Task<bool> CheckServiceActivityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsMov/SaveMovimento", ReplyAction="http://www.totvs.com/IwsMov/SaveMovimentoResponse")]
        string SaveMovimento(string xml, string contexto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsMov/SaveMovimento", ReplyAction="http://www.totvs.com/IwsMov/SaveMovimentoResponse")]
        System.Threading.Tasks.Task<string> SaveMovimentoAsync(string xml, string contexto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwsMovChannel : ClienteWStestes.WSMov.IwsMov, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwsMovClient : System.ServiceModel.ClientBase<ClienteWStestes.WSMov.IwsMov>, ClienteWStestes.WSMov.IwsMov {
        
        public IwsMovClient() {
        }
        
        public IwsMovClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IwsMovClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsMovClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsMovClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Implements(System.Type type) {
            return base.Channel.Implements(type);
        }
        
        public System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type) {
            return base.Channel.ImplementsAsync(type);
        }
        
        public bool CheckServiceActivity() {
            return base.Channel.CheckServiceActivity();
        }
        
        public System.Threading.Tasks.Task<bool> CheckServiceActivityAsync() {
            return base.Channel.CheckServiceActivityAsync();
        }
        
        public string SaveMovimento(string xml, string contexto) {
            return base.Channel.SaveMovimento(xml, contexto);
        }
        
        public System.Threading.Tasks.Task<string> SaveMovimentoAsync(string xml, string contexto) {
            return base.Channel.SaveMovimentoAsync(xml, contexto);
        }
    }
}
