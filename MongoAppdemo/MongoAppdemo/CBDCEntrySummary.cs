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
    
    public partial class CBDCEntrySummary
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public string EntryNo { get; set; }
        public Nullable<int> CheckDigit { get; set; }
        public string EntryType { get; set; }
        public string EntryPort { get; set; }
        public string Mode { get; set; }
        public string Carrier { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<System.DateTime> StatementDate { get; set; }
        public Nullable<int> StatementMonth { get; set; }
        public Nullable<double> GWT { get; set; }
        public Nullable<int> Customer { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> TotalDuty { get; set; }
        public Nullable<decimal> TotalHMF { get; set; }
        public Nullable<decimal> TotalMPF { get; set; }
        public Nullable<decimal> TotalValue { get; set; }
        public Nullable<decimal> TotalOtherFee { get; set; }
        public Nullable<decimal> TotalFee { get; set; }
        public Nullable<decimal> TotalADD { get; set; }
        public Nullable<decimal> TotalCVD { get; set; }
        public Nullable<decimal> TotalDue { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string PaymentCode { get; set; }
        public string DCCustomer { get; set; }
    }
}