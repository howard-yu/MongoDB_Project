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
    
    public partial class WMFCCharge
    {
        public int ID { get; set; }
        public Nullable<int> EVendorID { get; set; }
        public string ECurrencyCode { get; set; }
        public string ETransactionRate { get; set; }
        public Nullable<decimal> EGrsAmt { get; set; }
        public string EVAT { get; set; }
        public string EVATCode { get; set; }
        public Nullable<decimal> EVATAMT { get; set; }
        public Nullable<decimal> ETotalAMT { get; set; }
        public Nullable<decimal> ELocalVAT { get; set; }
        public Nullable<decimal> ELocalEquiv { get; set; }
        public string EstRefNo { get; set; }
        public Nullable<System.DateTime> EUpdateDate { get; set; }
        public string AVendorDoc { get; set; }
        public string ADocDate { get; set; }
        public string ACurrencyCode { get; set; }
        public string ATransactionRate { get; set; }
        public Nullable<decimal> AGrsAmt { get; set; }
        public Nullable<decimal> AVATAmt { get; set; }
        public Nullable<decimal> ATotalAmt { get; set; }
        public Nullable<decimal> ALocalVAT { get; set; }
        public Nullable<decimal> AlocalEquiv { get; set; }
        public string ARemark { get; set; }
        public Nullable<System.DateTime> ALastAppDate { get; set; }
        public Nullable<System.DateTime> CreatedDT { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDT { get; set; }
        public string UpdatedBy { get; set; }
        public string YearMonth { get; set; }
        public string StationID { get; set; }
        public Nullable<int> ChargeCodeID { get; set; }
        public string Status { get; set; }
        public string WMType { get; set; }
        public Nullable<int> WarehouseID { get; set; }
    }
}
