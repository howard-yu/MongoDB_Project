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
    
    public partial class SLJuniper_outMessage
    {
        public int ID { get; set; }
        public Nullable<int> TransHDID { get; set; }
        public string MsgType { get; set; }
        public string MSG_STAT { get; set; }
        public string F_Name { get; set; }
        public string Mail_Subject { get; set; }
        public Nullable<System.DateTime> CRT_DTM { get; set; }
        public Nullable<System.DateTime> COM_DTM { get; set; }
        public Nullable<System.DateTime> SND_DTM { get; set; }
        public Nullable<bool> MAIL_IND { get; set; }
        public Nullable<System.DateTime> MAIL_TM { get; set; }
    }
}