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
    
    public partial class SAQuoteFreightHistoricalRate
    {
        public int HQID { get; set; }
        public Nullable<int> LID { get; set; }
        public Nullable<int> OriginCityID { get; set; }
        public Nullable<int> DestinationCityID { get; set; }
        public Nullable<int> PloadingPortID { get; set; }
        public Nullable<int> PDischargePortID { get; set; }
        public Nullable<int> CarrierID { get; set; }
        public Nullable<int> ChargeItemID { get; set; }
        public Nullable<decimal> MinSellingRate { get; set; }
        public Nullable<decimal> MaxSellingRate { get; set; }
        public Nullable<decimal> LastYearSellingRate { get; set; }
        public Nullable<decimal> LastTwoYearSellingRate { get; set; }
        public Nullable<decimal> LastMonthSellingRate { get; set; }
        public Nullable<decimal> LastTwoMonthSellingRate { get; set; }
        public string isAllQuote { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
