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
    
    public partial class MSsavedforeignkeys
    {
        public string program_name { get; set; }
        public string constraint_name { get; set; }
        public string parent_schema { get; set; }
        public string parent_name { get; set; }
        public string referenced_object_schema { get; set; }
        public string referenced_object_name { get; set; }
        public bool is_disabled { get; set; }
        public bool is_not_for_replication { get; set; }
        public bool is_not_trusted { get; set; }
        public byte delete_referential_action { get; set; }
        public byte update_referential_action { get; set; }
        public System.DateTime timestamp { get; set; }
    }
}
