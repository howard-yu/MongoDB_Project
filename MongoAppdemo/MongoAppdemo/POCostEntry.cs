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
    
    public partial class POCostEntry
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public Nullable<int> Vendor { get; set; }
        public string DocNo { get; set; }
        public string LotPeriod { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<decimal> DocAmount { get; set; }
        public string VAT { get; set; }
        public Nullable<decimal> VATRate { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string Remark { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> ConfirmDate { get; set; }
        public string Createdby { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Updatedby { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> GLDate { get; set; }
        public string ConfirmBy { get; set; }
    }
}
