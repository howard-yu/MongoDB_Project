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
    
    public partial class AEBookConsole
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public int ID { get; set; }
        public string StationID { get; set; }
        public int OrgHAWBID { get; set; }
        public string OrgStationID { get; set; }
        public Nullable<System.DateTime> CargoAvailDate { get; set; }
        public string Area { get; set; }
        public string ServiceLevel { get; set; }
        public string DEPT { get; set; }
        public string DSTN { get; set; }
        public Nullable<int> BookingPCS { get; set; }
        public string BookingPCSUOM { get; set; }
        public Nullable<decimal> BookingWeight { get; set; }
        public Nullable<decimal> BookingCWT { get; set; }
        public Nullable<decimal> BookingVolume { get; set; }
        public string ShipperID { get; set; }
        public string ShipperLocalName { get; set; }
        public string Commodity { get; set; }
        public string DocType { get; set; }
        public string Carrier { get; set; }
        public string HAWBNo { get; set; }
        public string CS { get; set; }
        public string Rate { get; set; }
        public string Sales { get; set; }
        public string ShipingRemark { get; set; }
        public string BookingNo { get; set; }
        public string HeXiaoDanNo { get; set; }
        public string TuiDanNo { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string LoadMasterLoader { get; set; }
        public string LoadMAWBNo { get; set; }
        public string LoadCarrier { get; set; }
        public string LoadFLTNo { get; set; }
        public Nullable<System.DateTime> LoadETD { get; set; }
        public Nullable<System.DateTime> LoadETA { get; set; }
        public Nullable<System.DateTime> LoadATD { get; set; }
        public Nullable<int> LoadPCS { get; set; }
        public string LoadPCSType { get; set; }
        public Nullable<decimal> LoadWeight { get; set; }
        public string LoadWeightType { get; set; }
        public Nullable<decimal> LoadVolume { get; set; }
        public string LoadVolumeType { get; set; }
        public Nullable<decimal> LoadVWT { get; set; }
        public string LoadTerminal { get; set; }
        public string LoadPallet { get; set; }
        public string LoadStatus { get; set; }
        public string LoadEstCost { get; set; }
        public string LoadRemark { get; set; }
        public string LoadCreatedBy { get; set; }
        public Nullable<System.DateTime> LoadCreatedDate { get; set; }
        public string LoadUpdatedBy { get; set; }
        public Nullable<System.DateTime> LoadUpdatedDate { get; set; }
        public Nullable<int> WHPCS { get; set; }
        public string WHPCSType { get; set; }
        public Nullable<decimal> WHWeight { get; set; }
        public string WHWeightType { get; set; }
        public Nullable<decimal> WHVolume { get; set; }
        public string WHVolumeType { get; set; }
        public string WHCargoStatus { get; set; }
        public string WHRemark { get; set; }
        public string WHLocation { get; set; }
        public Nullable<System.DateTime> WHPulloutDT { get; set; }
        public string WHReceiptNo { get; set; }
        public string WHCreatedBy { get; set; }
        public Nullable<System.DateTime> WHCreatedDate { get; set; }
        public string WHUpdatedBy { get; set; }
        public Nullable<System.DateTime> WHUpdatedDate { get; set; }
        public Nullable<System.DateTime> WHHandoverDate { get; set; }
        public Nullable<System.DateTime> WHArrivalDate { get; set; }
        public string WHPallet { get; set; }
        public string WHDimension { get; set; }
        public Nullable<int> CSDeclareParty { get; set; }
        public Nullable<int> CSHandledBy { get; set; }
        public Nullable<System.DateTime> CSDecDate { get; set; }
        public Nullable<System.DateTime> CSReleaseDate { get; set; }
        public string CSStatus { get; set; }
        public string CSRemark { get; set; }
        public Nullable<System.DateTime> CSAvailDate { get; set; }
        public string CSCreatedBy { get; set; }
        public Nullable<System.DateTime> CSCreatedDate { get; set; }
        public string CSUpdatedBy { get; set; }
        public Nullable<System.DateTime> CSUpdatedDate { get; set; }
        public string RTHandBookNo { get; set; }
        public Nullable<System.DateTime> RTHandBookDate { get; set; }
        public Nullable<System.DateTime> RTHandBookOverDate { get; set; }
        public string RTHandBookSignBy { get; set; }
        public string RTHandBookCourier { get; set; }
        public string RTHexiaoDanNo { get; set; }
        public Nullable<System.DateTime> RTHexiaoDanDate { get; set; }
        public Nullable<System.DateTime> RTHexiaoDanOverDate { get; set; }
        public string RTHexiaoDanSignBy { get; set; }
        public string RTHexiaoDanCourier { get; set; }
        public string RTTuiShuiNo { get; set; }
        public Nullable<System.DateTime> RTTuiShuiDate { get; set; }
        public Nullable<System.DateTime> RTTuiShuiOverDate { get; set; }
        public string RTTuiShuiSignBy { get; set; }
        public string RTTuiShuiCourier { get; set; }
        public string RTRemark { get; set; }
        public string RTCreatedBy { get; set; }
        public Nullable<System.DateTime> RTCreatedDate { get; set; }
        public string RTUpdatedBy { get; set; }
        public Nullable<System.DateTime> RTUpdatedDate { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> ETD { get; set; }
        public string SalesPerson { get; set; }
        public Nullable<System.DateTime> WHCargoDate { get; set; }
        public string WHServiceLevel { get; set; }
        public string AWBType { get; set; }
        public string BookSend { get; set; }
        public string BookingWTUOM { get; set; }
        public string BookingVolumeUOM { get; set; }
        public string LoadMasterLoadName { get; set; }
        public Nullable<int> LoadID { get; set; }
        public Nullable<int> LoadPlanID { get; set; }
        public string AgentNo { get; set; }
        public string RTStatus { get; set; }
        public string HubRemark { get; set; }
        public Nullable<decimal> WHCWT { get; set; }
    }
}