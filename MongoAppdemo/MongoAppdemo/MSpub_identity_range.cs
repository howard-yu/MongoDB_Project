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
    
    public partial class MSpub_identity_range
    {
        public int objid { get; set; }
        public long range { get; set; }
        public long pub_range { get; set; }
        public long current_pub_range { get; set; }
        public int threshold { get; set; }
        public Nullable<long> last_seed { get; set; }
    }
}