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
    
    public partial class WMEntity
    {
        public int ID { get; set; }
        public Nullable<int> FunctionID { get; set; }
        public string EntityName { get; set; }
        public string EntityCode { get; set; }
        public string OrderNo { get; set; }
        public string MatchStatus { get; set; }
        public string NextStatus { get; set; }
        public string PageURL { get; set; }
        public string CreatedUserID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedUserID { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string Status { get; set; }
        public Nullable<bool> IsReload { get; set; }
    }
}
