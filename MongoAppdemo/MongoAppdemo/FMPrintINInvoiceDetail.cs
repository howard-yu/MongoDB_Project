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
    
    public partial class FMPrintINInvoiceDetail
    {
        public string StationID { get; set; }
        public string InvoiceNo { get; set; }
        public int PrintSeq { get; set; }
        public int PSeq { get; set; }
        public Nullable<int> PChargeID { get; set; }
        public string PDescription { get; set; }
        public string PPrintDescription { get; set; }
        public string PCurrencyCode { get; set; }
        public Nullable<double> CAFRate { get; set; }
        public Nullable<double> STransactionRate { get; set; }
        public Nullable<decimal> SAmount { get; set; }
        public Nullable<double> SVATRate { get; set; }
        public Nullable<decimal> SVATAmount { get; set; }
        public Nullable<decimal> STotalAmount { get; set; }
        public Nullable<decimal> PSalesAmount { get; set; }
        public Nullable<decimal> PInvoiceAmount { get; set; }
        public Nullable<double> PTransactionRate { get; set; }
        public string PrintAddress { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public int ID { get; set; }
    }
}