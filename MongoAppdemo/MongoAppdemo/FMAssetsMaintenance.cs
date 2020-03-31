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
    
    public partial class FMAssetsMaintenance
    {
        public string StationID { get; set; }
        public string AssetID { get; set; }
        public string AssetClass { get; set; }
        public string AssetName { get; set; }
        public string AssetDescription { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Unit { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<System.DateTime> DepreciationEffective { get; set; }
        public string OriginalPurchaseCostCoins { get; set; }
        public Nullable<decimal> OriginalPurchaseCost { get; set; }
        public string OriginalOtherCostCoins { get; set; }
        public Nullable<decimal> OriginalOtherCost { get; set; }
        public string HomePurchaseCostCoins { get; set; }
        public Nullable<decimal> HomePurchaseCost { get; set; }
        public string HomeOtherCostCoins { get; set; }
        public Nullable<decimal> HomeOtherCost { get; set; }
        public string UsefulLifeByMonth { get; set; }
        public Nullable<decimal> DepreciationByMonth { get; set; }
        public Nullable<decimal> ResidualValue { get; set; }
        public Nullable<decimal> AccumulatedDepreciation { get; set; }
        public Nullable<decimal> NetBookValue { get; set; }
        public string DepreciationExpenceCOA { get; set; }
        public string AccumulatedDepreciationCOA { get; set; }
        public Nullable<System.DateTime> ObsoleteDate { get; set; }
        public string ObsoleteUnit { get; set; }
        public Nullable<System.DateTime> DisposalDate { get; set; }
        public string DisposalUnit { get; set; }
        public Nullable<System.DateTime> WriteOffDate { get; set; }
        public string WriteOffUnit { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public byte[] Version { get; set; }
        public int ID { get; set; }
        public string PostFlag { get; set; }
        public string StatusType { get; set; }
        public Nullable<System.DateTime> StatusDate { get; set; }
        public string Division { get; set; }
        public string Project { get; set; }
        public string Department { get; set; }
        public Nullable<decimal> DisposalAmount { get; set; }
        public string GroupAssetID { get; set; }
        public Nullable<System.DateTime> IsPeriodicalDepreciation { get; set; }
        public string DepreciationCount { get; set; }
        public Nullable<decimal> DepreciationMod { get; set; }
        public string GroupID { get; set; }
        public Nullable<int> VenderID { get; set; }
        public string AssetDocNo { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string AssetInvoiceNo { get; set; }
        public string ProductLine { get; set; }
    }
}
