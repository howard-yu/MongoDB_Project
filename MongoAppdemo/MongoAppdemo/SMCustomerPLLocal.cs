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
    
    public partial class SMCustomerPLLocal
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public int CustomerID { get; set; }
        public int ProductLineID { get; set; }
        public Nullable<bool> IsStation { get; set; }
        public Nullable<bool> IsForeignAgent { get; set; }
        public Nullable<bool> IsLocalAgent { get; set; }
        public Nullable<bool> IsAirLine { get; set; }
        public Nullable<bool> IsOceanCarrier { get; set; }
        public Nullable<bool> IsCustomer { get; set; }
        public Nullable<bool> IsShipper { get; set; }
        public Nullable<bool> IsCNEE { get; set; }
        public Nullable<bool> Is3rdParty { get; set; }
        public Nullable<bool> IsNotify { get; set; }
        public Nullable<bool> IsBroker { get; set; }
        public Nullable<int> DASCarrierCountryID { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public byte[] Version { get; set; }
        public Nullable<bool> IsForward { get; set; }
        public Nullable<bool> IsTrucker { get; set; }
        public Nullable<bool> IsVendor { get; set; }
        public Nullable<bool> IsBillTo { get; set; }
        public Nullable<int> SalesPersonID { get; set; }
        public Nullable<int> CustomerServiceID { get; set; }
        public Nullable<bool> IsWarehouse { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<bool> IsCoLoad { get; set; }
        public Nullable<bool> IsBorrowin { get; set; }
        public Nullable<bool> AllowCoLoadOut { get; set; }
    }
}