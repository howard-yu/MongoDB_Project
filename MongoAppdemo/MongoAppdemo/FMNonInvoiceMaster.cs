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
    
    public partial class FMNonInvoiceMaster
    {
        public string StationID { get; set; }
        public string TempSeq { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string CreditKind { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> BillTo { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<decimal> InvoiceAmount { get; set; }
        public Nullable<decimal> SalesAmount { get; set; }
        public Nullable<decimal> VATAmount { get; set; }
        public Nullable<decimal> CreditAmount { get; set; }
        public Nullable<decimal> OpenAmount { get; set; }
        public Nullable<decimal> ReceivedAmount { get; set; }
        public string RecordFlag { get; set; }
        public string RefInvoiceNo { get; set; }
        public Nullable<double> BookRate { get; set; }
        public Nullable<System.DateTime> GLDate { get; set; }
        public string ConfirmedBy { get; set; }
        public string PrintedBy { get; set; }
        public Nullable<int> PrintTimes { get; set; }
        public string ModeCode { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> PostGLDate { get; set; }
        public string Subject { get; set; }
        public byte[] Version { get; set; }
        public int ID { get; set; }
        public string PayTerms { get; set; }
        public string BillAddress { get; set; }
        public string Remark { get; set; }
        public string LocalFlag { get; set; }
        public string JournalNo { get; set; }
        public string LJournalNo { get; set; }
        public string LumpSumUser { get; set; }
        public Nullable<int> LJournalSeq { get; set; }
        public string ApplyNO { get; set; }
        public string ApplyFlag { get; set; }
        public string ACSFlag { get; set; }
        public string Subject1 { get; set; }
        public Nullable<decimal> PostHAmount { get; set; }
    }
}
