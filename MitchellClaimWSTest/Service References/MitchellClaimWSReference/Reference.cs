﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MitchellClaimWSTest.MitchellClaimWSReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MitchellClaimType", Namespace="http://schemas.datacontract.org/2004/07/MitchellClaimWS")]
    [System.SerializableAttribute()]
    public partial class MitchellClaimType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long assignedAdjusterIDFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool assignedAdjusterIDFieldSpecifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string claimNumberFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string claimantFirstNameFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string claimantLastNameFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime lossDateFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool lossDateFieldSpecifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MitchellClaimWSTest.MitchellClaimWSReference.LossInfoType lossInfoFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MitchellClaimWSTest.MitchellClaimWSReference.StatusCode statusFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool statusFieldSpecifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MitchellClaimWSTest.MitchellClaimWSReference.VehicleInfoType[] vehiclesFieldField;
        
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
        public long assignedAdjusterIDField {
            get {
                return this.assignedAdjusterIDFieldField;
            }
            set {
                if ((this.assignedAdjusterIDFieldField.Equals(value) != true)) {
                    this.assignedAdjusterIDFieldField = value;
                    this.RaisePropertyChanged("assignedAdjusterIDField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool assignedAdjusterIDFieldSpecified {
            get {
                return this.assignedAdjusterIDFieldSpecifiedField;
            }
            set {
                if ((this.assignedAdjusterIDFieldSpecifiedField.Equals(value) != true)) {
                    this.assignedAdjusterIDFieldSpecifiedField = value;
                    this.RaisePropertyChanged("assignedAdjusterIDFieldSpecified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string claimNumberField {
            get {
                return this.claimNumberFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.claimNumberFieldField, value) != true)) {
                    this.claimNumberFieldField = value;
                    this.RaisePropertyChanged("claimNumberField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string claimantFirstNameField {
            get {
                return this.claimantFirstNameFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.claimantFirstNameFieldField, value) != true)) {
                    this.claimantFirstNameFieldField = value;
                    this.RaisePropertyChanged("claimantFirstNameField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string claimantLastNameField {
            get {
                return this.claimantLastNameFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.claimantLastNameFieldField, value) != true)) {
                    this.claimantLastNameFieldField = value;
                    this.RaisePropertyChanged("claimantLastNameField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime lossDateField {
            get {
                return this.lossDateFieldField;
            }
            set {
                if ((this.lossDateFieldField.Equals(value) != true)) {
                    this.lossDateFieldField = value;
                    this.RaisePropertyChanged("lossDateField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool lossDateFieldSpecified {
            get {
                return this.lossDateFieldSpecifiedField;
            }
            set {
                if ((this.lossDateFieldSpecifiedField.Equals(value) != true)) {
                    this.lossDateFieldSpecifiedField = value;
                    this.RaisePropertyChanged("lossDateFieldSpecified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MitchellClaimWSTest.MitchellClaimWSReference.LossInfoType lossInfoField {
            get {
                return this.lossInfoFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.lossInfoFieldField, value) != true)) {
                    this.lossInfoFieldField = value;
                    this.RaisePropertyChanged("lossInfoField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MitchellClaimWSTest.MitchellClaimWSReference.StatusCode statusField {
            get {
                return this.statusFieldField;
            }
            set {
                if ((this.statusFieldField.Equals(value) != true)) {
                    this.statusFieldField = value;
                    this.RaisePropertyChanged("statusField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool statusFieldSpecified {
            get {
                return this.statusFieldSpecifiedField;
            }
            set {
                if ((this.statusFieldSpecifiedField.Equals(value) != true)) {
                    this.statusFieldSpecifiedField = value;
                    this.RaisePropertyChanged("statusFieldSpecified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MitchellClaimWSTest.MitchellClaimWSReference.VehicleInfoType[] vehiclesField {
            get {
                return this.vehiclesFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.vehiclesFieldField, value) != true)) {
                    this.vehiclesFieldField = value;
                    this.RaisePropertyChanged("vehiclesField");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LossInfoType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class LossInfoType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MitchellClaimWSTest.MitchellClaimWSReference.CauseOfLossCode CauseOfLossField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CauseOfLossSpecifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LossDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReportedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ReportedDateSpecifiedField;
        
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
        public MitchellClaimWSTest.MitchellClaimWSReference.CauseOfLossCode CauseOfLoss {
            get {
                return this.CauseOfLossField;
            }
            set {
                if ((this.CauseOfLossField.Equals(value) != true)) {
                    this.CauseOfLossField = value;
                    this.RaisePropertyChanged("CauseOfLoss");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CauseOfLossSpecified {
            get {
                return this.CauseOfLossSpecifiedField;
            }
            set {
                if ((this.CauseOfLossSpecifiedField.Equals(value) != true)) {
                    this.CauseOfLossSpecifiedField = value;
                    this.RaisePropertyChanged("CauseOfLossSpecified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LossDescription {
            get {
                return this.LossDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.LossDescriptionField, value) != true)) {
                    this.LossDescriptionField = value;
                    this.RaisePropertyChanged("LossDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReportedDate {
            get {
                return this.ReportedDateField;
            }
            set {
                if ((this.ReportedDateField.Equals(value) != true)) {
                    this.ReportedDateField = value;
                    this.RaisePropertyChanged("ReportedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ReportedDateSpecified {
            get {
                return this.ReportedDateSpecifiedField;
            }
            set {
                if ((this.ReportedDateSpecifiedField.Equals(value) != true)) {
                    this.ReportedDateSpecifiedField = value;
                    this.RaisePropertyChanged("ReportedDateSpecified");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusCode", Namespace="http://schemas.datacontract.org/2004/07/")]
    public enum StatusCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OPEN = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CLOSED = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehicleInfoType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class VehicleInfoType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DamageDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EngineDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExteriorColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LicPlateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LicPlateExpDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool LicPlateExpDateSpecifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LicPlateStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MileageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool MileageSpecifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ModelYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VinField;
        
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
        public string DamageDescription {
            get {
                return this.DamageDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DamageDescriptionField, value) != true)) {
                    this.DamageDescriptionField = value;
                    this.RaisePropertyChanged("DamageDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EngineDescription {
            get {
                return this.EngineDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.EngineDescriptionField, value) != true)) {
                    this.EngineDescriptionField = value;
                    this.RaisePropertyChanged("EngineDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExteriorColor {
            get {
                return this.ExteriorColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ExteriorColorField, value) != true)) {
                    this.ExteriorColorField = value;
                    this.RaisePropertyChanged("ExteriorColor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LicPlate {
            get {
                return this.LicPlateField;
            }
            set {
                if ((object.ReferenceEquals(this.LicPlateField, value) != true)) {
                    this.LicPlateField = value;
                    this.RaisePropertyChanged("LicPlate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LicPlateExpDate {
            get {
                return this.LicPlateExpDateField;
            }
            set {
                if ((this.LicPlateExpDateField.Equals(value) != true)) {
                    this.LicPlateExpDateField = value;
                    this.RaisePropertyChanged("LicPlateExpDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool LicPlateExpDateSpecified {
            get {
                return this.LicPlateExpDateSpecifiedField;
            }
            set {
                if ((this.LicPlateExpDateSpecifiedField.Equals(value) != true)) {
                    this.LicPlateExpDateSpecifiedField = value;
                    this.RaisePropertyChanged("LicPlateExpDateSpecified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LicPlateState {
            get {
                return this.LicPlateStateField;
            }
            set {
                if ((object.ReferenceEquals(this.LicPlateStateField, value) != true)) {
                    this.LicPlateStateField = value;
                    this.RaisePropertyChanged("LicPlateState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MakeDescription {
            get {
                return this.MakeDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeDescriptionField, value) != true)) {
                    this.MakeDescriptionField = value;
                    this.RaisePropertyChanged("MakeDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Mileage {
            get {
                return this.MileageField;
            }
            set {
                if ((this.MileageField.Equals(value) != true)) {
                    this.MileageField = value;
                    this.RaisePropertyChanged("Mileage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool MileageSpecified {
            get {
                return this.MileageSpecifiedField;
            }
            set {
                if ((this.MileageSpecifiedField.Equals(value) != true)) {
                    this.MileageSpecifiedField = value;
                    this.RaisePropertyChanged("MileageSpecified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModelDescription {
            get {
                return this.ModelDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelDescriptionField, value) != true)) {
                    this.ModelDescriptionField = value;
                    this.RaisePropertyChanged("ModelDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ModelYear {
            get {
                return this.ModelYearField;
            }
            set {
                if ((this.ModelYearField.Equals(value) != true)) {
                    this.ModelYearField = value;
                    this.RaisePropertyChanged("ModelYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vin {
            get {
                return this.VinField;
            }
            set {
                if ((object.ReferenceEquals(this.VinField, value) != true)) {
                    this.VinField = value;
                    this.RaisePropertyChanged("Vin");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CauseOfLossCode", Namespace="http://schemas.datacontract.org/2004/07/")]
    public enum CauseOfLossCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Collision = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Explosion = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fire = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Hail = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MechanicalBreakdown = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MitchellClaimWSReference.IClaimService")]
    public interface IClaimService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClaimService/CreateClaim", ReplyAction="http://tempuri.org/IClaimService/CreateClaimResponse")]
        bool CreateClaim(string MitchellClaimXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClaimService/CreateClaim", ReplyAction="http://tempuri.org/IClaimService/CreateClaimResponse")]
        System.Threading.Tasks.Task<bool> CreateClaimAsync(string MitchellClaimXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClaimService/GetClaimByClaimNumber", ReplyAction="http://tempuri.org/IClaimService/GetClaimByClaimNumberResponse")]
        MitchellClaimWSTest.MitchellClaimWSReference.MitchellClaimType GetClaimByClaimNumber(string claimNumberField);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClaimService/GetClaimByClaimNumber", ReplyAction="http://tempuri.org/IClaimService/GetClaimByClaimNumberResponse")]
        System.Threading.Tasks.Task<MitchellClaimWSTest.MitchellClaimWSReference.MitchellClaimType> GetClaimByClaimNumberAsync(string claimNumberField);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClaimService/GetClaimsBetweenDates", ReplyAction="http://tempuri.org/IClaimService/GetClaimsBetweenDatesResponse")]
        MitchellClaimWSTest.MitchellClaimWSReference.MitchellClaimType[] GetClaimsBetweenDates(System.DateTime lossDate1, System.DateTime lossDate2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClaimService/GetClaimsBetweenDates", ReplyAction="http://tempuri.org/IClaimService/GetClaimsBetweenDatesResponse")]
        System.Threading.Tasks.Task<MitchellClaimWSTest.MitchellClaimWSReference.MitchellClaimType[]> GetClaimsBetweenDatesAsync(System.DateTime lossDate1, System.DateTime lossDate2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClaimServiceChannel : MitchellClaimWSTest.MitchellClaimWSReference.IClaimService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClaimServiceClient : System.ServiceModel.ClientBase<MitchellClaimWSTest.MitchellClaimWSReference.IClaimService>, MitchellClaimWSTest.MitchellClaimWSReference.IClaimService {
        
        public ClaimServiceClient() {
        }
        
        public ClaimServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClaimServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClaimServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClaimServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CreateClaim(string MitchellClaimXML) {
            return base.Channel.CreateClaim(MitchellClaimXML);
        }
        
        public System.Threading.Tasks.Task<bool> CreateClaimAsync(string MitchellClaimXML) {
            return base.Channel.CreateClaimAsync(MitchellClaimXML);
        }
        
        public MitchellClaimWSTest.MitchellClaimWSReference.MitchellClaimType GetClaimByClaimNumber(string claimNumberField) {
            return base.Channel.GetClaimByClaimNumber(claimNumberField);
        }
        
        public System.Threading.Tasks.Task<MitchellClaimWSTest.MitchellClaimWSReference.MitchellClaimType> GetClaimByClaimNumberAsync(string claimNumberField) {
            return base.Channel.GetClaimByClaimNumberAsync(claimNumberField);
        }
        
        public MitchellClaimWSTest.MitchellClaimWSReference.MitchellClaimType[] GetClaimsBetweenDates(System.DateTime lossDate1, System.DateTime lossDate2) {
            return base.Channel.GetClaimsBetweenDates(lossDate1, lossDate2);
        }
        
        public System.Threading.Tasks.Task<MitchellClaimWSTest.MitchellClaimWSReference.MitchellClaimType[]> GetClaimsBetweenDatesAsync(System.DateTime lossDate1, System.DateTime lossDate2) {
            return base.Channel.GetClaimsBetweenDatesAsync(lossDate1, lossDate2);
        }
    }
}
