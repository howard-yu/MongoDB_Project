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
    
    public partial class FMDocTempDetail
    {
        public int ID { get; set; }
        public Nullable<int> TempMID { get; set; }
        public Nullable<int> DetailID { get; set; }
        public Nullable<decimal> AppAmount { get; set; }
        public Nullable<decimal> AppVATAmount { get; set; }
        public string House { get; set; }
        public string Lot { get; set; }
        public string Master { get; set; }
        public string Charge { get; set; }
        public string Mode { get; set; }
        public Nullable<decimal> EstAmount { get; set; }
        public Nullable<decimal> EstVATAmount { get; set; }
        public Nullable<decimal> EstTotalAmount { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string StationID { get; set; }
        public string EstCurr { get; set; }
        public Nullable<decimal> EVATRate { get; set; }
        public string EstRefNo { get; set; }
        public string Tempseq { get; set; }
    }
}