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
    
    public partial class CBBrokerage
    {
        public int ID { get; set; }
        public string LotNo { get; set; }
        public Nullable<int> Customer { get; set; }
        public Nullable<int> SalesPerson { get; set; }
        public Nullable<int> BusinessType { get; set; }
        public string DivisionCode { get; set; }
        public string Declaration { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Remark { get; set; }
        public string StationID { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public byte[] Version { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string LotStatus { get; set; }
        public Nullable<int> CNEE { get; set; }
        public Nullable<int> DEPT { get; set; }
        public Nullable<int> DSTN { get; set; }
        public string Goods { get; set; }
        public Nullable<int> PCS { get; set; }
        public string PCSUOM { get; set; }
        public Nullable<int> SHPR { get; set; }
        public string Vessel { get; set; }
        public string Voyage { get; set; }
        public Nullable<double> WT { get; set; }
        public string WTUOM { get; set; }
        public Nullable<int> NTFY { get; set; }
        public Nullable<int> PReceipt { get; set; }
        public Nullable<System.DateTime> PReceiptETD { get; set; }
        public Nullable<System.DateTime> PReceiptATD { get; set; }
        public Nullable<int> PLoading { get; set; }
        public Nullable<System.DateTime> PLoadingETD { get; set; }
        public Nullable<System.DateTime> PLoadingATD { get; set; }
        public Nullable<int> PDischarge { get; set; }
        public Nullable<System.DateTime> PDischargeETD { get; set; }
        public Nullable<System.DateTime> PDischargeATD { get; set; }
        public Nullable<int> PDelivery { get; set; }
        public Nullable<System.DateTime> PDeliveryETD { get; set; }
        public Nullable<System.DateTime> PDeliveryATD { get; set; }
        public string PreAlertBy { get; set; }
        public Nullable<System.DateTime> PreAlertDT { get; set; }
        public string MoveType { get; set; }
        public Nullable<int> Carrier { get; set; }
        public string AMSBLNo { get; set; }
        public string SStationID { get; set; }
    }
}
