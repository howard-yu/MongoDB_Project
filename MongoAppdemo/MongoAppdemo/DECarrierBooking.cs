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
    
    public partial class DECarrierBooking
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public Nullable<int> SrcID { get; set; }
        public string SrcStationID { get; set; }
        public Nullable<int> MAWBID { get; set; }
        public Nullable<int> FromPort { get; set; }
        public Nullable<int> ToPort { get; set; }
        public string BookedFLT { get; set; }
        public string OnboardFLT { get; set; }
        public Nullable<System.DateTime> ETD { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public Nullable<System.DateTime> ATD { get; set; }
        public Nullable<System.DateTime> ATA { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDT { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDT { get; set; }
        public byte[] Version { get; set; }
    }
}