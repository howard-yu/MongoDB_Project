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
    
    public partial class TKStockMain
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public Nullable<int> StockID { get; set; }
        public Nullable<System.Guid> StockIDGUID { get; set; }
        public string CompID { get; set; }
        public Nullable<int> TruckID { get; set; }
        public Nullable<System.Guid> TruckIDGUID { get; set; }
        public Nullable<int> DriverID { get; set; }
        public Nullable<System.Guid> DriverIDGUID { get; set; }
        public string TruckNo { get; set; }
        public string DriverName { get; set; }
        public string DEPT { get; set; }
        public string DSTN { get; set; }
        public Nullable<int> IntendingMileage { get; set; }
        public Nullable<System.DateTime> ETD { get; set; }
        public Nullable<System.DateTime> ATD { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public Nullable<System.DateTime> ATA { get; set; }
        public string Status { get; set; }
        public string Mark { get; set; }
        public string Out_Mark { get; set; }
        public string In_Mark { get; set; }
        public Nullable<int> BackupDriverID { get; set; }
        public Nullable<System.Guid> BackupDriverIDGUID { get; set; }
        public Nullable<decimal> MainDriverCost { get; set; }
        public Nullable<decimal> BackupDriverCost { get; set; }
        public Nullable<decimal> TruckCost { get; set; }
        public Nullable<decimal> MainDriverMileageCost { get; set; }
        public Nullable<decimal> BackupDriverMileageCost { get; set; }
        public Nullable<decimal> TruckMileageCost { get; set; }
        public string OUTSOURCE { get; set; }
        public string VENDER { get; set; }
        public Nullable<int> VenderID { get; set; }
        public Nullable<System.Guid> VENDERIDGUID { get; set; }
        public Nullable<decimal> VENDER_TRUCK_TONNAGE { get; set; }
        public string VENDER_TRUCK_LICENSE_NO { get; set; }
        public string VENDER_DRIVER { get; set; }
        public string VENDER_CONTACT_NO { get; set; }
        public Nullable<int> VENDOR_TRUCK_ID { get; set; }
        public Nullable<System.Guid> VENDOR_TRUCK_IDGUID { get; set; }
        public string VENDOR_TRUCK_NO { get; set; }
        public string OUTSOURCE_TK_PHONE_HK { get; set; }
        public string OUTSOURCE_TK_PHONE_CN { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> TruckMileage { get; set; }
        public string LotNo { get; set; }
        public string Container { get; set; }
        public Nullable<int> LastMileage { get; set; }
        public Nullable<int> CurrMileage { get; set; }
        public string CostType { get; set; }
    }
}