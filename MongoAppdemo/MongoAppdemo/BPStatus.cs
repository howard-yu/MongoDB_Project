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
    
    public partial class BPStatus
    {
        public string StationID { get; set; }
        public int Year { get; set; }
        public Nullable<byte> InputVersion { get; set; }
        public Nullable<System.DateTime> UploadedDate { get; set; }
        public string UploadedBy { get; set; }
        public Nullable<byte> OutputVersion { get; set; }
        public Nullable<System.DateTime> DownloadedDate { get; set; }
        public string DownloadedBy { get; set; }
        public Nullable<byte> SentBRBVersion { get; set; }
        public Nullable<System.DateTime> SentBRBDate { get; set; }
        public string SentBRBBy { get; set; }
        public bool IsSendToBRB { get; set; }
        public Nullable<byte> SentBRBTimes { get; set; }
        public byte[] Version { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int ID { get; set; }
    }
}
