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
    
    public partial class SLRNPIP_3B2
    {
        public int ID { get; set; }
        public string msgFile { get; set; }
        public Nullable<System.DateTime> RevDT { get; set; }
        public Nullable<int> FromRole { get; set; }
        public Nullable<int> ToRole { get; set; }
        public string DocID { get; set; }
        public string DocDT { get; set; }
        public Nullable<int> BuyingPartner { get; set; }
        public Nullable<int> OriginatingPartner { get; set; }
        public Nullable<int> SellingPartner { get; set; }
        public string GlobalCarrierCode { get; set; }
        public string GlobalShippingServiceLevelCode { get; set; }
        public string numberOfShippingContainers { get; set; }
        public Nullable<int> ReceivingPartner { get; set; }
        public string ShipmentNo { get; set; }
        public string ShipmentTransportationEventDT { get; set; }
        public string ShipmentTransportationEventCode { get; set; }
        public string GlobalTrackingReferenceTypeCode { get; set; }
        public string ProprietaryShipmentTrackingIdentifier { get; set; }
        public Nullable<int> TransportedBy { get; set; }
        public string MsgStatus { get; set; }
        public string MsgException { get; set; }
        public string SLTransNo { get; set; }
        public string InstanceIdentifier { get; set; }
    }
}
