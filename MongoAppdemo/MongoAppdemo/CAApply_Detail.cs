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
    
    public partial class CAApply_Detail
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public string YYMonth { get; set; }
        public string InvNo { get; set; }
        public string InvStationID { get; set; }
        public string Inv_TempSeq { get; set; }
        public string Inv_ChargeCode { get; set; }
        public string Inv_ChargeCodeDesc { get; set; }
        public Nullable<double> Inv_VatRate { get; set; }
        public string Currency { get; set; }
        public Nullable<double> Currency_Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> LocalAmount { get; set; }
        public Nullable<double> Inv_VatRate_New { get; set; }
        public string Currency_New { get; set; }
        public Nullable<double> Currency_Rate_New { get; set; }
        public Nullable<decimal> Amount_New { get; set; }
        public Nullable<decimal> LocalAmount_New { get; set; }
        public string Status { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
