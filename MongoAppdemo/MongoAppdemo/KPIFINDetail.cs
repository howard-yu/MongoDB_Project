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
    
    public partial class KPIFINDetail
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public System.DateTime AsofDate { get; set; }
        public decimal RateToUSD { get; set; }
        public Nullable<decimal> TtlCurrAsst { get; set; }
        public Nullable<decimal> TtlCurrLiab { get; set; }
        public Nullable<decimal> TtlFixedAsst { get; set; }
        public Nullable<decimal> TtlEquity { get; set; }
        public Nullable<decimal> TtlLiab { get; set; }
        public Nullable<decimal> TtlAssetEqu { get; set; }
        public Nullable<decimal> DepOutVar { get; set; }
        public Nullable<decimal> DepOutLM { get; set; }
        public Nullable<decimal> TPAYMENTVAR { get; set; }
        public Nullable<decimal> TPAYMENTLM { get; set; }
        public Nullable<decimal> ADVANCEVAR { get; set; }
        public Nullable<decimal> ADVANCELM { get; set; }
        public Nullable<decimal> IOffAsstRecAccVar { get; set; }
        public Nullable<decimal> IOffAsstRecAccLM { get; set; }
        public Nullable<decimal> IOffLiabPayVAR { get; set; }
        public Nullable<decimal> IOffLiabPayLM { get; set; }
        public Nullable<decimal> IComAsstRecAccVar { get; set; }
        public Nullable<decimal> IComAsstRecAccLM { get; set; }
        public Nullable<decimal> IComLiabPayVAR { get; set; }
        public Nullable<decimal> IComLiabPayLM { get; set; }
        public Nullable<decimal> AROverDaysAmount { get; set; }
        public Nullable<decimal> ARAmount { get; set; }
        public Nullable<decimal> Revenus { get; set; }
        public Nullable<decimal> GP { get; set; }
        public Nullable<decimal> NPAfterTax { get; set; }
        public Nullable<decimal> Headcount { get; set; }
        public Nullable<decimal> ActOpOverHead { get; set; }
        public Nullable<decimal> BugtOpOverHead { get; set; }
        public Nullable<decimal> ActOpNetHead { get; set; }
        public Nullable<decimal> BugtOpNetHead { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
