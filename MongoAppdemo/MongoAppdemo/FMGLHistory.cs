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
    
    public partial class FMGLHistory
    {
        public string StationID { get; set; }
        public string JournalNo { get; set; }
        public int JournalSeq { get; set; }
        public string JournalRef { get; set; }
        public string ChartofAccount { get; set; }
        public string DCType { get; set; }
        public string FunctionType { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<decimal> OriginalAmount { get; set; }
        public Nullable<double> BookRate { get; set; }
        public string HCurrencyCode { get; set; }
        public Nullable<decimal> HAmount { get; set; }
        public string StatusType { get; set; }
        public string MonthEnd { get; set; }
        public Nullable<double> MonthBookRate { get; set; }
        public Nullable<decimal> UnrealizeGainLoss { get; set; }
        public Nullable<decimal> RealizedGainLoss { get; set; }
        public Nullable<decimal> TotalUnrealizeGainLoss { get; set; }
        public Nullable<decimal> TotalRealizedGainLoss { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public int ID { get; set; }
    }
}