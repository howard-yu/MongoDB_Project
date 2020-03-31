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
    
    public partial class OEISFA_HEADER
    {
        public string UUID { get; set; }
        public string STATUS { get; set; }
        public string SHIPMENT_NUMBER { get; set; }
        public string ACCESS_GROUP { get; set; }
        public string ACT { get; set; }
        public string REPLY_TO { get; set; }
        public string NOTIFY_EMAIL { get; set; }
        public string IMPORTER_DATE_OF_BIRTH { get; set; }
        public string IMPORTER_COUNTRY_OF_ISSUANCE { get; set; }
        public string IMPORTER_DESC { get; set; }
        public string IMPORTER_ID_VALUE { get; set; }
        public string IMPORTER_ID_TYPE { get; set; }
        public string SHIPMENT_TYPE { get; set; }
        public string ISF_TRANSACTION_NUMBER { get; set; }
        public string CONTAINERIZED { get; set; }
        public string CARRIER { get; set; }
        public string ACTION_REASON_CODE { get; set; }
        public string POL_VALUE { get; set; }
        public string POL_DESC { get; set; }
        public string POA_VALUE { get; set; }
        public string POA_DESC { get; set; }
        public string POD_VALUE { get; set; }
        public string POD_DESC { get; set; }
        public string ETD { get; set; }
        public string ETA { get; set; }
        public string VESSEL { get; set; }
        public string VOYAGE { get; set; }
        public string BOND_HOLDER { get; set; }
        public string BOND_ACTIVITY { get; set; }
        public string BOND_TYPE { get; set; }
        public string SURETY_ID { get; set; }
        public string BOND_REFERENCE_NUMBER { get; set; }
        public string CARNET_COUNTRY { get; set; }
        public string CARNET_NUMBER { get; set; }
        public string CRT_USR { get; set; }
        public Nullable<System.DateTime> CRT_DTM { get; set; }
        public string UPD_USR { get; set; }
        public Nullable<System.DateTime> UPD_DTM { get; set; }
        public string ShipmentType { get; set; }
        public string SCACCode { get; set; }
        public string StationID { get; set; }
        public string PurposeCode { get; set; }
        public string TypeOfEntry { get; set; }
        public string SNPPartyCode { get; set; }
        public string ACKMsg { get; set; }
    
        public virtual OEISFA_PARTY OEISFA_PARTY { get; set; }
    }
}
