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
    
    public partial class FMNonPrintInvoiceMaster
    {
        public string StationID { get; set; }
        public string InvoiceNo { get; set; }
        public int NPrintSeq { get; set; }
        public Nullable<int> NBillTo { get; set; }
        public Nullable<System.DateTime> NDate { get; set; }
        public string NPayTerms { get; set; }
        public string NCurrencyCode { get; set; }
        public string NRemark { get; set; }
        public Nullable<decimal> NSubTotal { get; set; }
        public string VATType { get; set; }
        public Nullable<decimal> NVATAmount { get; set; }
        public Nullable<decimal> NInvoiceAmount { get; set; }
        public Nullable<int> NPrintTimes { get; set; }
        public string NSubject { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public int ID { get; set; }
        public string PrintAddress { get; set; }
    }
}