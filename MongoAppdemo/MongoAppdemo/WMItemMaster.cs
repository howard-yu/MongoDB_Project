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
    
    public partial class WMItemMaster
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public string ItemCode { get; set; }
        public string ItemDesc { get; set; }
        public Nullable<int> ConsigneeID { get; set; }
        public Nullable<int> VendorID { get; set; }
        public string ItemUOM { get; set; }
        public Nullable<decimal> NW { get; set; }
        public Nullable<decimal> GW { get; set; }
        public Nullable<decimal> NetPrice { get; set; }
        public string HSCode { get; set; }
        public string ChinaName { get; set; }
        public Nullable<int> SafeStockQTY { get; set; }
        public Nullable<System.DateTime> ExpiredDate { get; set; }
        public string VItemCode { get; set; }
        public string VItemDesc { get; set; }
        public string CItemCode { get; set; }
        public string CItemDesc { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Depth { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> Qty { get; set; }
        public string ImageName { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDT { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDT { get; set; }
        public string StationID { get; set; }
        public string ECCN { get; set; }
        public string NWUOM { get; set; }
        public string GWUOM { get; set; }
        public string WidthUOM { get; set; }
        public string LengthUOM { get; set; }
        public string DepthUOM { get; set; }
    }
}