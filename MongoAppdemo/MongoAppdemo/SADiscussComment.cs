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
    
    public partial class SADiscussComment
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string ReplyUserID { get; set; }
        public Nullable<System.DateTime> CommentTime { get; set; }
        public string SourceType { get; set; }
        public Nullable<int> SourceID { get; set; }
        public string Attachments { get; set; }
    }
}
