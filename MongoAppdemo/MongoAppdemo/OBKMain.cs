//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MongoAppdemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class OBKMain
    {
        public int ID { get; set; }
        public int SourceID { get; set; }
        public string SourceNo { get; set; }
        public string BKType { get; set; }
        public string MessageReferenceNo { get; set; }
        public string ShipmentID { get; set; }
        public string MessageFunctionCode { get; set; }
        public string ResponseTypeCode { get; set; }
        public string BookingContactName { get; set; }
        public string BKEmail { get; set; }
        public string BKTel { get; set; }
        public string BKFax { get; set; }
        public string DocDate { get; set; }
        public string CarriageConditionCode { get; set; }
        public string CancellationReason { get; set; }
        public string AmendmentReason { get; set; }
        public string SCACCode { get; set; }
        public string NatureOfCargo { get; set; }
        public int PlaceOfReceiptID { get; set; }
        public string PlaceOfReceiptCode { get; set; }
        public string PlaceOfReceipteName { get; set; }
        public string ETD { get; set; }
        public int PlaceOfDeliveryID { get; set; }
        public string PlaceOfDeliveryCode { get; set; }
        public string PlaceOfDeliveryName { get; set; }
        public string ETA { get; set; }
        public Nullable<int> CarrierPLoadingID { get; set; }
        public string CarrierPLoadingCode { get; set; }
        public string CarrierPLoadingName { get; set; }
        public string RefFunctionCode { get; set; }
        public string RefNumber { get; set; }
        public string VoyageNo { get; set; }
        public string MainCarriageTransMode { get; set; }
        public string MainCarriageTransMean { get; set; }
        public string TransMeanDesc { get; set; }
        public string CarrierSCACCode { get; set; }
        public string VesselName { get; set; }
        public Nullable<int> PLoadingID { get; set; }
        public string PLoadingCode { get; set; }
        public string PLoadingName { get; set; }
        public string PLoadingETD { get; set; }
        public Nullable<int> PDischargeID { get; set; }
        public string PDischargeCode { get; set; }
        public string PDischargeName { get; set; }
        public string VoyageNoAlisaCode { get; set; }
        public string BKPartCompany { get; set; }
        public string BKPartCompanyAddress1 { get; set; }
        public string BKPartCompanyAddress2 { get; set; }
        public string BKPartCompanyAddress3 { get; set; }
        public string BKPartCompanyAddress4 { get; set; }
        public string BKContactPerson { get; set; }
        public string BKPEmail { get; set; }
        public string BKPTel { get; set; }
        public string BKPFax { get; set; }
        public string CarrierName { get; set; }
        public string CarrierNameAlisaCode { get; set; }
        public Nullable<int> ShipperID { get; set; }
        public string ShipperName { get; set; }
        public string ShipperAddress1 { get; set; }
        public string ShipperAddress2 { get; set; }
        public string ShipperAddress3 { get; set; }
        public string ShipperAddress4 { get; set; }
        public string ShipperAlisaCode { get; set; }
        public Nullable<int> ForwarderID { get; set; }
        public string ForwarderName { get; set; }
        public string ForwarderAddress1 { get; set; }
        public string ForwarderAddress2 { get; set; }
        public string ForwarderAddress3 { get; set; }
        public string ForwarderAddress4 { get; set; }
        public Nullable<int> CNEEID { get; set; }
        public string CNEEName { get; set; }
        public string CNEEAddress1 { get; set; }
        public string CNEEAddress2 { get; set; }
        public string CNEEAddress3 { get; set; }
        public string CNEEAddress4 { get; set; }
        public Nullable<int> NotifyID { get; set; }
        public string NotifyName { get; set; }
        public string NotifyAddress1 { get; set; }
        public string NotifyAddress2 { get; set; }
        public string NotifyAddress3 { get; set; }
        public string NotifyAddress4 { get; set; }
        public string ChargeCategoryCode { get; set; }
        public string PCIndicator { get; set; }
        public Nullable<int> NumberOfPackage { get; set; }
        public string PackageType { get; set; }
        public string PackageTypeDesc { get; set; }
        public string HarmonizedCode { get; set; }
        public string GoodsDesc { get; set; }
        public Nullable<decimal> TotalWT { get; set; }
        public Nullable<decimal> TotalCBM { get; set; }
        public string IMOCode { get; set; }
        public string HazardPageNo { get; set; }
        public string HazardVersion { get; set; }
        public string UNDGNo { get; set; }
        public Nullable<decimal> FlashPoint { get; set; }
        public string DangerTemperatureUnit { get; set; }
        public string PackingGroupCode { get; set; }
        public string EMSNo { get; set; }
        public string TermCardNo { get; set; }
        public string IMOCode2 { get; set; }
        public string IMOCode3 { get; set; }
        public string DangerShipName { get; set; }
        public string EmergencyContact { get; set; }
        public string CommunicationNo { get; set; }
        public string ContainerType { get; set; }
        public string EquipmentSupplierCode { get; set; }
        public Nullable<int> ContainerQuantity { get; set; }
        public string MovementType { get; set; }
        public string HaulageArrangeCode { get; set; }
        public Nullable<decimal> ContainerWeight { get; set; }
        public Nullable<decimal> TemperatureSetting { get; set; }
        public string TemperatureUnit { get; set; }
        public string ShipFromName { get; set; }
        public string ShipFromAddress1 { get; set; }
        public string ShipFromAddress2 { get; set; }
        public string ShipFromAddress3 { get; set; }
        public string ShipFromAddress4 { get; set; }
        public Nullable<System.DateTime> EmptyEquipmentDT { get; set; }
        public Nullable<System.DateTime> PickupDT { get; set; }
        public string ShipFromContact { get; set; }
        public string ShipFromEmail { get; set; }
        public string ShipFromTel { get; set; }
        public string ShipFromFax { get; set; }
        public string ShipToName { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToAddress3 { get; set; }
        public string ShipToAddress4 { get; set; }
        public Nullable<System.DateTime> DeliveryDT { get; set; }
        public string ShipToContact { get; set; }
        public string ShipToEmail { get; set; }
        public string ShipToTel { get; set; }
        public string ShipToFax { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
        public string SendStatus { get; set; }
        public string SendFileName { get; set; }
        public Nullable<int> SendIndex { get; set; }
        public string EDIReceive { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public string ReceiveFileName { get; set; }
        public Nullable<int> MBLID { get; set; }
        public string PDischargeETD { get; set; }
        public string DangerousCode { get; set; }
        public Nullable<int> DangerousID { get; set; }
        public Nullable<int> ContainerID { get; set; }
        public Nullable<int> PackageID { get; set; }
        public string StationID { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string BKPartCompanyAlisaCode { get; set; }
    }
}
