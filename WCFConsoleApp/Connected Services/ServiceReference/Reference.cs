﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFConsoleApp.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComplexType", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class ComplexType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RzeczewistaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double UrojonaField;
        
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
        public double Rzeczewista {
            get {
                return this.RzeczewistaField;
            }
            set {
                if ((this.RzeczewistaField.Equals(value) != true)) {
                    this.RzeczewistaField = value;
                    this.RaisePropertyChanged("Rzeczewista");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Urojona {
            get {
                return this.UrojonaField;
            }
            set {
                if ((this.UrojonaField.Equals(value) != true)) {
                    this.UrojonaField = value;
                    this.RaisePropertyChanged("Urojona");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ICalculatorSevice")]
    public interface ICalculatorSevice {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/dodawanie4Param", ReplyAction="http://tempuri.org/ICalculatorSevice/dodawanie4ParamResponse")]
        string dodawanie4Param(double rz_1, double ur_1, double rz_2, double ur_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/dodawanie4Param", ReplyAction="http://tempuri.org/ICalculatorSevice/dodawanie4ParamResponse")]
        System.Threading.Tasks.Task<string> dodawanie4ParamAsync(double rz_1, double ur_1, double rz_2, double ur_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/odejmowanie4Param", ReplyAction="http://tempuri.org/ICalculatorSevice/odejmowanie4ParamResponse")]
        string odejmowanie4Param(double rz_1, double ur_1, double rz_2, double ur_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/odejmowanie4Param", ReplyAction="http://tempuri.org/ICalculatorSevice/odejmowanie4ParamResponse")]
        System.Threading.Tasks.Task<string> odejmowanie4ParamAsync(double rz_1, double ur_1, double rz_2, double ur_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/mnozenie4Param", ReplyAction="http://tempuri.org/ICalculatorSevice/mnozenie4ParamResponse")]
        string mnozenie4Param(double rz_1, double ur_1, double rz_2, double ur_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/mnozenie4Param", ReplyAction="http://tempuri.org/ICalculatorSevice/mnozenie4ParamResponse")]
        System.Threading.Tasks.Task<string> mnozenie4ParamAsync(double rz_1, double ur_1, double rz_2, double ur_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/dzielenie4Param", ReplyAction="http://tempuri.org/ICalculatorSevice/dzielenie4ParamResponse")]
        string dzielenie4Param(double rz_1, double ur_1, double rz_2, double ur_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/dzielenie4Param", ReplyAction="http://tempuri.org/ICalculatorSevice/dzielenie4ParamResponse")]
        System.Threading.Tasks.Task<string> dzielenie4ParamAsync(double rz_1, double ur_1, double rz_2, double ur_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/dodawanie2Param", ReplyAction="http://tempuri.org/ICalculatorSevice/dodawanie2ParamResponse")]
        string dodawanie2Param(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/dodawanie2Param", ReplyAction="http://tempuri.org/ICalculatorSevice/dodawanie2ParamResponse")]
        System.Threading.Tasks.Task<string> dodawanie2ParamAsync(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/odejmowanie2Param", ReplyAction="http://tempuri.org/ICalculatorSevice/odejmowanie2ParamResponse")]
        string odejmowanie2Param(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/odejmowanie2Param", ReplyAction="http://tempuri.org/ICalculatorSevice/odejmowanie2ParamResponse")]
        System.Threading.Tasks.Task<string> odejmowanie2ParamAsync(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/mnozenie2Param", ReplyAction="http://tempuri.org/ICalculatorSevice/mnozenie2ParamResponse")]
        string mnozenie2Param(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/mnozenie2Param", ReplyAction="http://tempuri.org/ICalculatorSevice/mnozenie2ParamResponse")]
        System.Threading.Tasks.Task<string> mnozenie2ParamAsync(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/dzielenie2Param", ReplyAction="http://tempuri.org/ICalculatorSevice/dzielenie2ParamResponse")]
        string dzielenie2Param(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorSevice/dzielenie2Param", ReplyAction="http://tempuri.org/ICalculatorSevice/dzielenie2ParamResponse")]
        System.Threading.Tasks.Task<string> dzielenie2ParamAsync(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorSeviceChannel : WCFConsoleApp.ServiceReference.ICalculatorSevice, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorSeviceClient : System.ServiceModel.ClientBase<WCFConsoleApp.ServiceReference.ICalculatorSevice>, WCFConsoleApp.ServiceReference.ICalculatorSevice {
        
        public CalculatorSeviceClient() {
        }
        
        public CalculatorSeviceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorSeviceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSeviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSeviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string dodawanie4Param(double rz_1, double ur_1, double rz_2, double ur_2) {
            return base.Channel.dodawanie4Param(rz_1, ur_1, rz_2, ur_2);
        }
        
        public System.Threading.Tasks.Task<string> dodawanie4ParamAsync(double rz_1, double ur_1, double rz_2, double ur_2) {
            return base.Channel.dodawanie4ParamAsync(rz_1, ur_1, rz_2, ur_2);
        }
        
        public string odejmowanie4Param(double rz_1, double ur_1, double rz_2, double ur_2) {
            return base.Channel.odejmowanie4Param(rz_1, ur_1, rz_2, ur_2);
        }
        
        public System.Threading.Tasks.Task<string> odejmowanie4ParamAsync(double rz_1, double ur_1, double rz_2, double ur_2) {
            return base.Channel.odejmowanie4ParamAsync(rz_1, ur_1, rz_2, ur_2);
        }
        
        public string mnozenie4Param(double rz_1, double ur_1, double rz_2, double ur_2) {
            return base.Channel.mnozenie4Param(rz_1, ur_1, rz_2, ur_2);
        }
        
        public System.Threading.Tasks.Task<string> mnozenie4ParamAsync(double rz_1, double ur_1, double rz_2, double ur_2) {
            return base.Channel.mnozenie4ParamAsync(rz_1, ur_1, rz_2, ur_2);
        }
        
        public string dzielenie4Param(double rz_1, double ur_1, double rz_2, double ur_2) {
            return base.Channel.dzielenie4Param(rz_1, ur_1, rz_2, ur_2);
        }
        
        public System.Threading.Tasks.Task<string> dzielenie4ParamAsync(double rz_1, double ur_1, double rz_2, double ur_2) {
            return base.Channel.dzielenie4ParamAsync(rz_1, ur_1, rz_2, ur_2);
        }
        
        public string dodawanie2Param(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2) {
            return base.Channel.dodawanie2Param(Zes_1, Zes_2);
        }
        
        public System.Threading.Tasks.Task<string> dodawanie2ParamAsync(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2) {
            return base.Channel.dodawanie2ParamAsync(Zes_1, Zes_2);
        }
        
        public string odejmowanie2Param(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2) {
            return base.Channel.odejmowanie2Param(Zes_1, Zes_2);
        }
        
        public System.Threading.Tasks.Task<string> odejmowanie2ParamAsync(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2) {
            return base.Channel.odejmowanie2ParamAsync(Zes_1, Zes_2);
        }
        
        public string mnozenie2Param(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2) {
            return base.Channel.mnozenie2Param(Zes_1, Zes_2);
        }
        
        public System.Threading.Tasks.Task<string> mnozenie2ParamAsync(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2) {
            return base.Channel.mnozenie2ParamAsync(Zes_1, Zes_2);
        }
        
        public string dzielenie2Param(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2) {
            return base.Channel.dzielenie2Param(Zes_1, Zes_2);
        }
        
        public System.Threading.Tasks.Task<string> dzielenie2ParamAsync(WCFConsoleApp.ServiceReference.ComplexType Zes_1, WCFConsoleApp.ServiceReference.ComplexType Zes_2) {
            return base.Channel.dzielenie2ParamAsync(Zes_1, Zes_2);
        }
    }
}
