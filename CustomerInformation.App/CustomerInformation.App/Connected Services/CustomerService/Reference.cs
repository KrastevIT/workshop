﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerInformation.App.CustomerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerCreateModel", Namespace="http://schemas.datacontract.org/2004/07/CustomerInformation.Models.Customers")]
    [System.SerializableAttribute()]
    public partial class CustomerCreateModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CustomerInformation.App.CustomerService.AddressCreateModel[] HomeAddressesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CustomerInformation.App.CustomerService.AddressCreateModel[] OfficeAddressesField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CustomerInformation.App.CustomerService.AddressCreateModel[] HomeAddresses {
            get {
                return this.HomeAddressesField;
            }
            set {
                if ((object.ReferenceEquals(this.HomeAddressesField, value) != true)) {
                    this.HomeAddressesField = value;
                    this.RaisePropertyChanged("HomeAddresses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CustomerInformation.App.CustomerService.AddressCreateModel[] OfficeAddresses {
            get {
                return this.OfficeAddressesField;
            }
            set {
                if ((object.ReferenceEquals(this.OfficeAddressesField, value) != true)) {
                    this.OfficeAddressesField = value;
                    this.RaisePropertyChanged("OfficeAddresses");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AddressCreateModel", Namespace="http://schemas.datacontract.org/2004/07/CustomerInformation.Models.Addresses")]
    [System.SerializableAttribute()]
    public partial class AddressCreateModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] PhoneNumbersField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] PhoneNumbers {
            get {
                return this.PhoneNumbersField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumbersField, value) != true)) {
                    this.PhoneNumbersField = value;
                    this.RaisePropertyChanged("PhoneNumbers");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerUpdateModel", Namespace="http://schemas.datacontract.org/2004/07/CustomerInformation.Models.Customers")]
    [System.SerializableAttribute()]
    public partial class CustomerUpdateModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HomeAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HomeAddressIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HomePhoneIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HomePhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OfficeAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OfficeAddressIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OfficePhoneIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OfficePhoneNumberField;
        
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
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HomeAddress {
            get {
                return this.HomeAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.HomeAddressField, value) != true)) {
                    this.HomeAddressField = value;
                    this.RaisePropertyChanged("HomeAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HomeAddressId {
            get {
                return this.HomeAddressIdField;
            }
            set {
                if ((this.HomeAddressIdField.Equals(value) != true)) {
                    this.HomeAddressIdField = value;
                    this.RaisePropertyChanged("HomeAddressId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HomePhoneId {
            get {
                return this.HomePhoneIdField;
            }
            set {
                if ((this.HomePhoneIdField.Equals(value) != true)) {
                    this.HomePhoneIdField = value;
                    this.RaisePropertyChanged("HomePhoneId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HomePhoneNumber {
            get {
                return this.HomePhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.HomePhoneNumberField, value) != true)) {
                    this.HomePhoneNumberField = value;
                    this.RaisePropertyChanged("HomePhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OfficeAddress {
            get {
                return this.OfficeAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.OfficeAddressField, value) != true)) {
                    this.OfficeAddressField = value;
                    this.RaisePropertyChanged("OfficeAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OfficeAddressId {
            get {
                return this.OfficeAddressIdField;
            }
            set {
                if ((this.OfficeAddressIdField.Equals(value) != true)) {
                    this.OfficeAddressIdField = value;
                    this.RaisePropertyChanged("OfficeAddressId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OfficePhoneId {
            get {
                return this.OfficePhoneIdField;
            }
            set {
                if ((this.OfficePhoneIdField.Equals(value) != true)) {
                    this.OfficePhoneIdField = value;
                    this.RaisePropertyChanged("OfficePhoneId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OfficePhoneNumber {
            get {
                return this.OfficePhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.OfficePhoneNumberField, value) != true)) {
                    this.OfficePhoneNumberField = value;
                    this.RaisePropertyChanged("OfficePhoneNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerService.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/Create", ReplyAction="http://tempuri.org/ICustomerService/CreateResponse")]
        bool Create(CustomerInformation.App.CustomerService.CustomerCreateModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/Create", ReplyAction="http://tempuri.org/ICustomerService/CreateResponse")]
        System.Threading.Tasks.Task<bool> CreateAsync(CustomerInformation.App.CustomerService.CustomerCreateModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/Update", ReplyAction="http://tempuri.org/ICustomerService/UpdateResponse")]
        bool Update(CustomerInformation.App.CustomerService.CustomerUpdateModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/Update", ReplyAction="http://tempuri.org/ICustomerService/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(CustomerInformation.App.CustomerService.CustomerUpdateModel model);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : CustomerInformation.App.CustomerService.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<CustomerInformation.App.CustomerService.ICustomerService>, CustomerInformation.App.CustomerService.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Create(CustomerInformation.App.CustomerService.CustomerCreateModel model) {
            return base.Channel.Create(model);
        }
        
        public System.Threading.Tasks.Task<bool> CreateAsync(CustomerInformation.App.CustomerService.CustomerCreateModel model) {
            return base.Channel.CreateAsync(model);
        }
        
        public bool Update(CustomerInformation.App.CustomerService.CustomerUpdateModel model) {
            return base.Channel.Update(model);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(CustomerInformation.App.CustomerService.CustomerUpdateModel model) {
            return base.Channel.UpdateAsync(model);
        }
    }
}
