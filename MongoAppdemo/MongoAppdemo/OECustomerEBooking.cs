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
    
    public partial class OECustomerEBooking
    {
        public int ID { get; set; }
        public Nullable<int> CustID { get; set; }
        public Nullable<int> SrcID { get; set; }
        public Nullable<int> HBLID { get; set; }
        public string StationID { get; set; }
        public string BookingNo { get; set; }
        public Nullable<int> PLoading { get; set; }
        public Nullable<System.DateTime> PLoadingETD { get; set; }
        public Nullable<int> PDelivery { get; set; }
        public string MoveType { get; set; }
        public string NatureOfGoodsType { get; set; }
        public string OPType1 { get; set; }
        public string OPType3 { get; set; }
        public string OPType3Detail { get; set; }
        public string OPType3Remark { get; set; }
        public string OPType2 { get; set; }
        public string OPTypeDetail { get; set; }
        public string FreightPayType { get; set; }
        public string TradeType { get; set; }
        public string ClientPIC { get; set; }
        public string ClientEmail { get; set; }
        public string ClientTel { get; set; }
        public string ClientFax { get; set; }
        public string IsSelfConsol { get; set; }
        public Nullable<int> ConsolGroup { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string HBLType { get; set; }
        public Nullable<System.DateTime> CargoReadyDate { get; set; }
    }
}
