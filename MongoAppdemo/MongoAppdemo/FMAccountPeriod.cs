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
    
    public partial class FMAccountPeriod
    {
        public string StationID { get; set; }
        public string Period { get; set; }
        public string ModelType { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string MonthAction { get; set; }
        public string LastPeriod { get; set; }
        public Nullable<System.DateTime> OpenDate { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int ID { get; set; }
        public Nullable<System.DateTime> IsPeriodicalDepreciation { get; set; }
        public Nullable<System.DateTime> IsSendCRP { get; set; }
        public Nullable<System.DateTime> IsCalculateMonthEndData { get; set; }
        public Nullable<System.DateTime> IsCloseSalesRevRptAir { get; set; }
        public Nullable<System.DateTime> IsCloseSalesRevRptSea { get; set; }
        public Nullable<System.DateTime> IsCloseSalesRevRptOcean { get; set; }
        public Nullable<bool> CalBPData { get; set; }
        public Nullable<System.DateTime> IsCalARMonthEnd { get; set; }
        public Nullable<System.DateTime> IsCalAPMonthEnd { get; set; }
    }
}