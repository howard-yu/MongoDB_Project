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
    
    public partial class FMNonInvoiceDetail
    {
        public string StationID { get; set; }
        public string TempSeq { get; set; }
        public string InvoiceNo { get; set; }
        public decimal Seq { get; set; }
        public string Credit_Debit { get; set; }
        public Nullable<int> ChargeID { get; set; }
        public string CurrencyCode { get; set; }
        public string TransactionRate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<double> VAT { get; set; }
        public Nullable<short> VATNo { get; set; }
        public Nullable<decimal> VATAmount { get; set; }
        public Nullable<decimal> HVATAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> InvSAmount { get; set; }
        public Nullable<decimal> InvSVATAmount { get; set; }
        public Nullable<decimal> InvSTotalAmount { get; set; }
        public Nullable<decimal> LocalEquiv { get; set; }
        public string CreditFlag { get; set; }
        public string JournalNo { get; set; }
        public Nullable<decimal> JournalSeq { get; set; }
        public string RefInvoice { get; set; }
        public Nullable<decimal> RefSeq { get; set; }
        public string LJournalNo { get; set; }
        public Nullable<decimal> LJournalSeq { get; set; }
        public string LumpsumUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public string Division { get; set; }
        public string Project { get; set; }
        public string Department { get; set; }
        public int ID { get; set; }
        public string PrintDescription { get; set; }
        public string ProductLine { get; set; }
    }
}
