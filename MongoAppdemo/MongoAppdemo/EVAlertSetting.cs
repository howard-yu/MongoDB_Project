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
    
    public partial class EVAlertSetting
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public string CreatedSource { get; set; }
        public short AlertType { get; set; }
        public short Via { get; set; }
        public Nullable<int> ORG { get; set; }
        public Nullable<int> DSTN { get; set; }
        public string ServiceLevel { get; set; }
        public string OrderNo { get; set; }
        public int ShipmentType { get; set; }
        public Nullable<int> AirDoc { get; set; }
        public Nullable<int> OceanDoc { get; set; }
        public int AlertRule { get; set; }
        public int Milestone1 { get; set; }
        public Nullable<int> Milestone2 { get; set; }
        public Nullable<int> Action { get; set; }
        public Nullable<int> Hours { get; set; }
        public string Status { get; set; }
        public string Updateby { get; set; }
        public System.DateTime Updatedate { get; set; }
        public Nullable<int> Version { get; set; }
        public string ORGType { get; set; }
        public string DSTNType { get; set; }
        public Nullable<bool> TrackingDoc { get; set; }
    }
}
