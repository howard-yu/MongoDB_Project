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
    
    public partial class TKTruckPayout
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public int OrderID { get; set; }
        public int TruckID { get; set; }
        public Nullable<System.Guid> TruckGUIDID { get; set; }
        public string TruckCostType { get; set; }
        public int TruckCostID { get; set; }
        public Nullable<System.Guid> TruckPayoutGUID { get; set; }
        public Nullable<int> ChargeID { get; set; }
        public string SC_CODE { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> VendorID { get; set; }
        public string VENDOR { get; set; }
        public string VENDOR_DESC { get; set; }
        public Nullable<System.DateTime> PAYOUT_DATE { get; set; }
        public string REFNO { get; set; }
        public Nullable<double> CHARGE_AMT { get; set; }
        public string CURR { get; set; }
        public Nullable<double> CURR_RATE { get; set; }
        public Nullable<decimal> MILEAGE { get; set; }
        public string TYPE { get; set; }
        public string STATUS_IN_VP { get; set; }
        public Nullable<int> Jobnum { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string VATNo { get; set; }
        public Nullable<double> VATAmount { get; set; }
        public Nullable<bool> AllInVat { get; set; }
        public Nullable<int> StockID { get; set; }
    }
}
