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
    
    public partial class SASalesTask
    {
        public int ID { get; set; }
        public Nullable<int> LID { get; set; }
        public string Subject { get; set; }
        public string AssignTo { get; set; }
        public string Attendees { get; set; }
        public string Contact { get; set; }
        public string SalesTaskInfo { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string Status { get; set; }
        public string LocationCity { get; set; }
        public string LocationAddress { get; set; }
        public string LogType { get; set; }
        public string Priority { get; set; }
        public string TaskOwnerID { get; set; }
        public Nullable<bool> AllDayEvent { get; set; }
        public string AttendeeContact { get; set; }
        public string CreatedUserID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedUserID { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string SubjectType { get; set; }
    }
}
