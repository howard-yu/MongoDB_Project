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
    
    public partial class CBSBBillingTmp
    {
        public int ID { get; set; }
        public string EntryNo { get; set; }
        public string BillNo { get; set; }
        public int SEQ { get; set; }
        public string BillTo { get; set; }
        public string ChargeCode { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string VendorID { get; set; }
        public string PayChargeCode { get; set; }
        public string PayCurrency { get; set; }
        public Nullable<decimal> PayCost { get; set; }
        public Nullable<short> flag1 { get; set; }
        public Nullable<short> flag2 { get; set; }
        public Nullable<short> flag3 { get; set; }
        public Nullable<short> flag4 { get; set; }
    }
}
