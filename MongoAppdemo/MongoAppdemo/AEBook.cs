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
    
    public partial class AEBook
    {
        public int ID { get; set; }
        public int HAWBID { get; set; }
        public string Area { get; set; }
        public string ServiceLevel { get; set; }
        public Nullable<decimal> BookingCWT { get; set; }
        public Nullable<decimal> BookingVolume { get; set; }
        public string ShipperLocalName { get; set; }
        public string LocalCommodity { get; set; }
        public string DocType { get; set; }
        public string DSTNStationID { get; set; }
        public string Status { get; set; }
        public string CS { get; set; }
        public string Rate { get; set; }
        public string Remark { get; set; }
        public string ShipingRemark { get; set; }
        public string Carrier { get; set; }
        public string SalesPerson { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string LoadStation1 { get; set; }
        public string LoadMasterLoader1 { get; set; }
        public string LoadCarrier1 { get; set; }
        public string LoadMAWBNo1 { get; set; }
        public string LoadEstCost1 { get; set; }
        public string LoadFLTNo1 { get; set; }
        public string LoadTerminal1 { get; set; }
        public string LoadStation2 { get; set; }
        public string LoadMasterLoader2 { get; set; }
        public string LoadCarrier2 { get; set; }
        public string LoadMAWBNo2 { get; set; }
        public string LoadEstCost2 { get; set; }
        public string LoadFLTNo2 { get; set; }
        public string BookSend { get; set; }
        public string WHCargoStatus { get; set; }
        public string WHLocation { get; set; }
        public Nullable<decimal> WHVolume { get; set; }
        public string WHDimension { get; set; }
        public string RTHexiaoDanNo { get; set; }
        public Nullable<System.DateTime> RTTuiShuiDate { get; set; }
        public string CSStatus { get; set; }
        public Nullable<int> BookingPCS { get; set; }
        public string BookingPCSUOM { get; set; }
        public Nullable<decimal> BookingGWT { get; set; }
        public string BookingWTUOM { get; set; }
        public string BookingVolumeUOM { get; set; }
        public Nullable<System.DateTime> HubCargoDate { get; set; }
        public string HubServiceLevel { get; set; }
    }
}