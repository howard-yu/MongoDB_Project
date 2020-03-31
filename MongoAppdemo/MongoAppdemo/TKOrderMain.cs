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
    
    public partial class TKOrderMain
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public Nullable<System.Guid> OrderID { get; set; }
        public string CompID { get; set; }
        public string OrderNo { get; set; }
        public string WayBill { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.Guid> CustomerIDGUID { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerLinkman { get; set; }
        public string CustomerPhone { get; set; }
        public Nullable<System.DateTime> PrearrangeTruckDate { get; set; }
        public Nullable<System.DateTime> GetCargoDate { get; set; }
        public string GetCargoDate_HOUR { get; set; }
        public string GetCargoDate_MINUTE { get; set; }
        public Nullable<int> GetCargoCompanyID { get; set; }
        public Nullable<System.Guid> GetCargoCompanyIDGUID { get; set; }
        public string GetCargoAddress { get; set; }
        public string GetCargoLinkman { get; set; }
        public string GetCargoPhone { get; set; }
        public Nullable<int> SendCargoCompanyID { get; set; }
        public Nullable<System.Guid> SendCargoCompanyIDGUID { get; set; }
        public string SendCargoAddress { get; set; }
        public string SendCargoLinkman { get; set; }
        public string SendCargoPhone { get; set; }
        public Nullable<int> DeliveryCargoCompanyID { get; set; }
        public Nullable<System.Guid> DeliveryCargoCompanyIDGUID { get; set; }
        public string DeliveryCargoAddress { get; set; }
        public string DeliveryCargoLinkman { get; set; }
        public string DeliveryCargoPhone { get; set; }
        public Nullable<int> PayCostCustomerID { get; set; }
        public Nullable<System.Guid> PayCostCustomerIDGUID { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<System.Guid> DeptIDGUID { get; set; }
        public Nullable<int> DstnID { get; set; }
        public Nullable<System.Guid> DstnIDGUID { get; set; }
        public string KeyGuy { get; set; }
        public string KeyPhone { get; set; }
        public string Port { get; set; }
        public string BusinessType { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Cubage { get; set; }
        public Nullable<int> Items { get; set; }
        public string UOM { get; set; }
        public string ItemType { get; set; }
        public string ContainerNo { get; set; }
        public string IsSpecial { get; set; }
        public string IsIncludeCargo { get; set; }
        public string IsPrearrange { get; set; }
        public string Status { get; set; }
        public string Mark { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string MAWBNO { get; set; }
        public string HAWBNO { get; set; }
        public Nullable<decimal> CostWeight { get; set; }
        public string Mark1 { get; set; }
        public string Operater { get; set; }
        public string InsuranceNo { get; set; }
        public string FileType { get; set; }
        public Nullable<System.DateTime> OrderNo_Date { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public byte[] Version { get; set; }
        public string InvType { get; set; }
        public string CostType { get; set; }
        public Nullable<bool> isCBRF { get; set; }
        public Nullable<int> Broker { get; set; }
    }
}