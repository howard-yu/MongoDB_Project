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
    
    public partial class SMCMRForm
    {
        public int ID { get; set; }
        public string CMRNo { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<int> Shipper { get; set; }
        public string ShipperAddress { get; set; }
        public Nullable<int> CNEE { get; set; }
        public string CNEEAddress { get; set; }
        public Nullable<int> Delivery { get; set; }
        public string DeliveryAddress { get; set; }
        public Nullable<System.DateTime> PickupDate { get; set; }
        public string PickupCountry { get; set; }
        public string AdditionalDocument { get; set; }
        public string HandlingInstruction { get; set; }
        public Nullable<short> Paid { get; set; }
        public Nullable<double> Payment { get; set; }
        public Nullable<int> TransportID { get; set; }
        public string TransportAddress { get; set; }
        public string TransportCarrier { get; set; }
        public string Remarks { get; set; }
        public string SpecialAgreement { get; set; }
        public string SignaturePlace { get; set; }
        public Nullable<System.DateTime> SignatureDate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
