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
    
    public partial class MSpeer_lsns
    {
        public int id { get; set; }
        public Nullable<System.DateTime> last_updated { get; set; }
        public string originator { get; set; }
        public string originator_db { get; set; }
        public string originator_publication { get; set; }
        public Nullable<int> originator_publication_id { get; set; }
        public Nullable<int> originator_db_version { get; set; }
        public byte[] originator_lsn { get; set; }
        public Nullable<int> originator_version { get; set; }
        public Nullable<int> originator_id { get; set; }
    }
}