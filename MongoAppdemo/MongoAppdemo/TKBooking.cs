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
    
    public partial class TKBooking
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public string CreateStationID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string BookingNo { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerLinkman { get; set; }
        public string CustomerPhone { get; set; }
        public Nullable<System.DateTime> PrearrangeTruckDate { get; set; }
        public Nullable<System.DateTime> GetCargoDate { get; set; }
        public Nullable<int> GetCargoCompanyID { get; set; }
        public string GetCargoAddress { get; set; }
        public string GetCargoLinkman { get; set; }
        public string GetCargoPhone { get; set; }
        public Nullable<int> SendCargoCompanyID { get; set; }
        public string SendCargoAddress { get; set; }
        public string SendCargoLinkman { get; set; }
        public string SendCargoPhone { get; set; }
        public Nullable<int> DeliveryCargoCompanyID { get; set; }
        public string DeliveryCargoAddress { get; set; }
        public string DeliveryCargoLinkman { get; set; }
        public string DeliveryCargoPhone { get; set; }
        public Nullable<int> PayCostCustomerID { get; set; }
        public Nullable<int> DeptID { get; set; }
        public string DeptName { get; set; }
        public Nullable<int> DstnID { get; set; }
        public string DSTNName { get; set; }
        public string KeyGuy { get; set; }
        public string KeyPhone { get; set; }
        public string Status { get; set; }
        public string Mark { get; set; }
        public string MAWBNO { get; set; }
        public string HAWBNO { get; set; }
        public Nullable<int> Items { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> CostWeight { get; set; }
        public Nullable<decimal> Cubage { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string InStockNo { get; set; }
    }
}