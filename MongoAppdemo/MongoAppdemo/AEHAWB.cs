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
    
    public partial class AEHAWB
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public int ID { get; set; }
        public Nullable<int> MAWBID { get; set; }
        public Nullable<int> ParentAWB { get; set; }
        public string HAWBNo { get; set; }
        public Nullable<int> Customer { get; set; }
        public Nullable<int> BBAgent { get; set; }
        public Nullable<int> Shipper { get; set; }
        public Nullable<int> CNEE { get; set; }
        public Nullable<int> Notify { get; set; }
        public Nullable<int> ThirdParty { get; set; }
        public string Sales { get; set; }
        public string FRT { get; set; }
        public string Other { get; set; }
        public string Move { get; set; }
        public Nullable<int> ActPCS { get; set; }
        public string ActPCSUOM { get; set; }
        public Nullable<int> SPUnit { get; set; }
        public string SPUnitUOM { get; set; }
        public Nullable<double> GWT { get; set; }
        public Nullable<double> VWT { get; set; }
        public Nullable<double> CWT { get; set; }
        public string WTUOM { get; set; }
        public string ClassRate { get; set; }
        public Nullable<double> Rate { get; set; }
        public string Currency { get; set; }
        public Nullable<bool> ShowRate { get; set; }
        public string ExportLIC { get; set; }
        public string Quantity { get; set; }
        public string CommInv { get; set; }
        public string DESC { get; set; }
        public string Remark { get; set; }
        public string Marks { get; set; }
        public string SPINST { get; set; }
        public string AWBType { get; set; }
        public Nullable<int> PortOfDEPT { get; set; }
        public Nullable<int> PortOfDSTN { get; set; }
        public Nullable<int> PlaceOfRCPT { get; set; }
        public Nullable<int> PlaceOfDELV { get; set; }
        public string TradeTerm { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string PrintPerson { get; set; }
        public Nullable<double> DueToAgent { get; set; }
        public Nullable<double> DueToCarrier { get; set; }
        public Nullable<System.DateTime> ArriDate { get; set; }
        public Nullable<System.DateTime> DeptDate { get; set; }
        public Nullable<System.DateTime> AvaiDate { get; set; }
        public Nullable<double> CUFT { get; set; }
        public Nullable<bool> CYM { get; set; }
        public Nullable<bool> NoExpect { get; set; }
        public Nullable<int> CustomsDeclareParty { get; set; }
        public Nullable<int> CustomsHandledBy { get; set; }
        public string CustomsDocType { get; set; }
        public Nullable<System.DateTime> CustomsAvaDate { get; set; }
        public Nullable<System.DateTime> CustomsDecDate { get; set; }
        public string CustomsRemark { get; set; }
        public string CustomsStatus { get; set; }
        public Nullable<int> WHActPCS { get; set; }
        public string WHActPCSUOM { get; set; }
        public Nullable<double> WHActWT { get; set; }
        public string WHActWTUOM { get; set; }
        public Nullable<double> WHActVWT { get; set; }
        public string WHActVWTUOM { get; set; }
        public string WHLocation { get; set; }
        public Nullable<System.DateTime> WHArrivalDate { get; set; }
        public Nullable<System.DateTime> WHPulloutDate { get; set; }
        public string WHContainer { get; set; }
        public string WHRemark { get; set; }
        public string WHCargoStatus { get; set; }
        public string WHReceiptNo { get; set; }
        public string PreAlertUser { get; set; }
        public Nullable<System.DateTime> PreAlertDate { get; set; }
        public Nullable<int> BookedPCS { get; set; }
        public string BookedWTUOM { get; set; }
        public Nullable<double> BookedGWT { get; set; }
        public Nullable<double> BookedVWT { get; set; }
        public string Status { get; set; }
        public string StationID { get; set; }
        public string ServiceLevel { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public byte[] Version { get; set; }
        public string SStationID { get; set; }
        public string ShptType { get; set; }
        public string ReferenceCode { get; set; }
        public string SPL { get; set; }
        public string IMPStation { get; set; }
        public string BKNO { get; set; }
        public string ConfirmID { get; set; }
        public string HSCode { get; set; }
        public string UNCode { get; set; }
        public string MTSNO { get; set; }
        public Nullable<int> ImportAgent { get; set; }
        public Nullable<int> SourceID { get; set; }
        public string FRTParty { get; set; }
        public string DBID { get; set; }
        public string Extra0 { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Extra4 { get; set; }
        public string Extra5 { get; set; }
        public string Extra6 { get; set; }
        public string Extra7 { get; set; }
        public string Extra8 { get; set; }
        public string Extra9 { get; set; }
        public Nullable<int> CopyAIID { get; set; }
        public string TransShipmentMode { get; set; }
        public Nullable<int> TransShipmentPort { get; set; }
        public Nullable<bool> ExportCustoms { get; set; }
        public Nullable<bool> ImportCustoms { get; set; }
        public Nullable<int> AirportOfDEPT { get; set; }
        public Nullable<int> AirportOfDSTN { get; set; }
    }
}
