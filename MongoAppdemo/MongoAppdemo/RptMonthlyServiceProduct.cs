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
    
    public partial class RptMonthlyServiceProduct
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public string Period { get; set; }
        public Nullable<int> CustomerHQID { get; set; }
        public string Category { get; set; }
        public string AgentProfile { get; set; }
        public string LeadStationCode { get; set; }
        public Nullable<decimal> ToalRevenue { get; set; }
        public Nullable<decimal> TotalGP { get; set; }
        public Nullable<decimal> SalesContribution { get; set; }
        public Nullable<decimal> GPContribution { get; set; }
        public Nullable<decimal> VSTotalExpense { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
