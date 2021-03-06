﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication.WsFornecedores {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FornecedorDB", Namespace="http://schemas.datacontract.org/2004/07/WebService.Models")]
    [System.SerializableAttribute()]
    public partial class FornecedorDB : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CnpjField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RazaoSocialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleApplication.WsFornecedores.PedidoDB[] pedidosField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cnpj {
            get {
                return this.CnpjField;
            }
            set {
                if ((object.ReferenceEquals(this.CnpjField, value) != true)) {
                    this.CnpjField = value;
                    this.RaisePropertyChanged("Cnpj");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RazaoSocial {
            get {
                return this.RazaoSocialField;
            }
            set {
                if ((object.ReferenceEquals(this.RazaoSocialField, value) != true)) {
                    this.RazaoSocialField = value;
                    this.RaisePropertyChanged("RazaoSocial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefoneField, value) != true)) {
                    this.TelefoneField = value;
                    this.RaisePropertyChanged("Telefone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleApplication.WsFornecedores.PedidoDB[] pedidos {
            get {
                return this.pedidosField;
            }
            set {
                if ((object.ReferenceEquals(this.pedidosField, value) != true)) {
                    this.pedidosField = value;
                    this.RaisePropertyChanged("pedidos");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PedidoDB", Namespace="http://schemas.datacontract.org/2004/07/WebService.Models")]
    [System.SerializableAttribute()]
    public partial class PedidoDB : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntregaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrazoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TotalField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Entrega {
            get {
                return this.EntregaField;
            }
            set {
                if ((object.ReferenceEquals(this.EntregaField, value) != true)) {
                    this.EntregaField = value;
                    this.RaisePropertyChanged("Entrega");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prazo {
            get {
                return this.PrazoField;
            }
            set {
                if ((object.ReferenceEquals(this.PrazoField, value) != true)) {
                    this.PrazoField = value;
                    this.RaisePropertyChanged("Prazo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsFornecedores.IIWsFornecedores")]
    public interface IIWsFornecedores {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWsFornecedores/GetAll", ReplyAction="http://tempuri.org/IIWsFornecedores/GetAllResponse")]
        ConsoleApplication.WsFornecedores.FornecedorDB[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWsFornecedores/GetAll", ReplyAction="http://tempuri.org/IIWsFornecedores/GetAllResponse")]
        System.Threading.Tasks.Task<ConsoleApplication.WsFornecedores.FornecedorDB[]> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIWsFornecedoresChannel : ConsoleApplication.WsFornecedores.IIWsFornecedores, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IWsFornecedoresClient : System.ServiceModel.ClientBase<ConsoleApplication.WsFornecedores.IIWsFornecedores>, ConsoleApplication.WsFornecedores.IIWsFornecedores {
        
        public IWsFornecedoresClient() {
        }
        
        public IWsFornecedoresClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IWsFornecedoresClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IWsFornecedoresClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IWsFornecedoresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsoleApplication.WsFornecedores.FornecedorDB[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication.WsFornecedores.FornecedorDB[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}
