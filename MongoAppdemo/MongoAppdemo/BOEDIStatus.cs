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
    
    public partial class BOEDIStatus
    {
        public int ID { get; set; }
        public int MBLID { get; set; }
        public string StationID { get; set; }
        public string SO_Status { get; set; }
        public string SO_EDISendBy { get; set; }
        public Nullable<System.DateTime> SO_EDISendDT { get; set; }
        public string SO_EDISendFile { get; set; }
        public string SO_ACKStatus { get; set; }
        public Nullable<System.DateTime> SO_ACKDT { get; set; }
        public string SO_ISANo { get; set; }
        public string SI_Status { get; set; }
        public string SI_EDISendBy { get; set; }
        public Nullable<System.DateTime> SI_EDISendDT { get; set; }
        public string SI_EDISendFile { get; set; }
        public string SI_ACKStatus { get; set; }
        public Nullable<System.DateTime> SI_ACKDT { get; set; }
        public string SI_ISANo { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDT { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDT { get; set; }
    }
}
