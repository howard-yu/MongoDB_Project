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
    
    public partial class SMMilestoneDetail
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public string ParentkeyValue { get; set; }
        public string ContainerKey { get; set; }
        public string POKey { get; set; }
        public string SOKey { get; set; }
        public Nullable<int> ProductLine { get; set; }
        public Nullable<int> MilestoneID { get; set; }
        public Nullable<System.DateTime> MilestoneTime { get; set; }
        public string ExtraValue1 { get; set; }
        public string ExtraValue2 { get; set; }
        public Nullable<int> UTCOffset { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> CreatedDT { get; set; }
        public string CreatedBy { get; set; }
        public string MilestoneCityCode { get; set; }
        public Nullable<System.DateTime> MilestoneUTCTime { get; set; }
        public Nullable<System.DateTime> CreatedUTCTime { get; set; }
    }
}
