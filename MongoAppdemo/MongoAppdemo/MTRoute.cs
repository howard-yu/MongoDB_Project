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
    
    public partial class MTRoute
    {
        public int ID { get; set; }
        public int MTSDataID { get; set; }
        public int MTSSeq { get; set; }
        public string MTSMode { get; set; }
        public Nullable<int> Receipt { get; set; }
        public Nullable<int> Delivery { get; set; }
        public string ReceiptStation { get; set; }
        public string DeliveryStation { get; set; }
        public Nullable<int> DEPT { get; set; }
        public Nullable<int> DSTN { get; set; }
        public Nullable<int> POL { get; set; }
        public Nullable<int> POD { get; set; }
        public string Vessel { get; set; }
        public string Voyage { get; set; }
        public string FLTNo { get; set; }
        public Nullable<int> Agent { get; set; }
        public string StationID { get; set; }
        public string HouseNo { get; set; }
        public string MasterNo { get; set; }
        public string Lot { get; set; }
        public string HType { get; set; }
        public Nullable<System.DateTime> ETD { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public Nullable<System.DateTime> ATD { get; set; }
        public Nullable<System.DateTime> ATA { get; set; }
        public string NetureOfGoods { get; set; }
        public Nullable<double> CBM { get; set; }
        public Nullable<int> PCS { get; set; }
        public string PCSUOM { get; set; }
        public Nullable<double> CWT { get; set; }
        public Nullable<double> GWT { get; set; }
        public Nullable<double> VWT { get; set; }
        public string WTUOM { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string Mode { get; set; }
    }
}