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
    
    public partial class AIEntryDT
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public int ID { get; set; }
        public int HAWBID { get; set; }
        public int EntryID { get; set; }
        public Nullable<int> EntryPCS { get; set; }
        public Nullable<double> EntryWT { get; set; }
        public string StationID { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public byte[] Version { get; set; }
        public Nullable<int> Damage { get; set; }
        public Nullable<int> Offload { get; set; }
        public Nullable<int> Shortage { get; set; }
        public Nullable<int> Supplus { get; set; }
        public Nullable<double> DamageWT { get; set; }
        public Nullable<double> ShortageWT { get; set; }
        public Nullable<double> SupplusWT { get; set; }
        public string Remark { get; set; }
    }
}
