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
    
    public partial class MSsubscription_agents
    {
        public int id { get; set; }
        public string publisher { get; set; }
        public string publisher_db { get; set; }
        public string publication { get; set; }
        public int subscription_type { get; set; }
        public string queue_id { get; set; }
        public byte update_mode { get; set; }
        public bool failover_mode { get; set; }
        public int spid { get; set; }
        public System.DateTime login_time { get; set; }
        public bool allow_subscription_copy { get; set; }
        public int attach_state { get; set; }
        public byte[] attach_version { get; set; }
        public Nullable<int> last_sync_status { get; set; }
        public string last_sync_summary { get; set; }
        public Nullable<System.DateTime> last_sync_time { get; set; }
        public string queue_server { get; set; }
    }
}