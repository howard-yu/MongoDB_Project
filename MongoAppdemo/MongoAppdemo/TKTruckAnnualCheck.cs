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
    
    public partial class TKTruckAnnualCheck
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public int TruckID { get; set; }
        public Nullable<System.Guid> TruckAnnualCheckID { get; set; }
        public Nullable<System.Guid> TruckGUID { get; set; }
        public string CompID { get; set; }
        public Nullable<decimal> CheckPrice { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> CheckFrom { get; set; }
        public Nullable<System.DateTime> CheckTo { get; set; }
        public Nullable<System.DateTime> FinishDate { get; set; }
        public Nullable<decimal> PriceDay { get; set; }
        public string IsFinish { get; set; }
        public string Mark { get; set; }
        public Nullable<decimal> TotalMileage { get; set; }
        public string TYPE { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
