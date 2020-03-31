﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICenter.Areas.CSP.Models
{
    [BsonIgnoreExtraElements]
    public class OPShipmentData
    {
        //public MongoDB.Bson.ObjectId _id { get; set; }
        public int ID { get; set; }
        public string PL { get; set; }
        public string KeyValue { get; set; }
        public string IDType { get; set; }
        public string Status { get; set; }
        public string MasterNo { get; set; }
        public string HouseNo { get; set; }
        public string ESkirtSID { get; set; }
        public Nullable<int> ESkirtHID { get; set; }
        public Nullable<int> ESkirtMID { get; set; }
        public string MStationID { get; set; }
        public string EHubSID { get; set; }
        public Nullable<int> EHubHID { get; set; }
        public string IHubSID { get; set; }
        public Nullable<int> IHubHID { get; set; }
        public string ISkirtSID { get; set; }
        public Nullable<int> ISkirtHID { get; set; }
        public Nullable<int> ISkirtMID { get; set; }
        public string ISkirtMSID { get; set; }
        public string ELotNo { get; set; }
        public string ILotNo { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> Origin { get; set; }
        public string OriginCityCode { get; set; }
        public string OriginCityName { get; set; }
        public string OriginCountryCode { get; set; }
        public string OriginCountryName { get; set; }
        public Nullable<int> POL { get; set; }
        public string POLCode { get; set; }
        public string POLName { get; set; }
        public string POLCountryCode { get; set; }
        public string POLCountryName { get; set; }
        public Nullable<int> POD { get; set; }
        public string PODCode { get; set; }
        public string PODName { get; set; }
        public string PODCountryCode { get; set; }
        public string PODCountryName { get; set; }
        public Nullable<int> DSTN { get; set; }
        public string DSTNCityCode { get; set; }
        public string DSTNCityName { get; set; }
        public string DSTNCountryCode { get; set; }
        public string DSTNCountryName { get; set; }
        public Nullable<int> Shipper { get; set; }
        public string ShipperCode { get; set; }
        public string ShipperName { get; set; }
        public string HouseShipperName { get; set; }
        public string HouseShipperAddr { get; set; }
        public Nullable<int> CNEE { get; set; }
        public string CNEECode { get; set; }
        public string CNEEName { get; set; }
        public string HouseCNEEName { get; set; }
        public string HouseCNEEAddr { get; set; }
        public Nullable<int> Notify { get; set; }
        public string NotifyCode { get; set; }
        public string NotifyName { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string ServiceLevel { get; set; }
        public string TradeTerm { get; set; }
        public string Move { get; set; }
        public string BookedFLT { get; set; }
        public string OnBoardFLT { get; set; }
        public string Vessel { get; set; }
        public string Voyage { get; set; }
        public Nullable<decimal> CWT { get; set; }
        public string CWTUOM { get; set; }
        public Nullable<decimal> GWT { get; set; }
        public string GWTUOM { get; set; }
        public Nullable<int> PCS { get; set; }
        public string PCSUOM { get; set; }
        public Nullable<decimal> CBM { get; set; }
        public Nullable<decimal> TEU { get; set; }
        public Nullable<int> C20 { get; set; }
        public Nullable<int> C40 { get; set; }
        public Nullable<int> C40H { get; set; }
        public Nullable<int> C45 { get; set; }
        public Nullable<int> OtherCNTR { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Remark { get; set; }
        public string DIMINV { get; set; }
        public string CTNRNo { get; set; }
        public string PickAddr { get; set; }
        public string DELVAddr { get; set; }
        public Nullable<int> PickPCS { get; set; }
        public string PickPCSUOM { get; set; }
        public Nullable<double> PickWeight { get; set; }
        public string PickWeightUOM { get; set; }
        public Nullable<System.DateTime> ActualPickup { get; set; }
        public string PickRemark { get; set; }
        public Nullable<double> VWT { get; set; }
        public Nullable<double> Volumn { get; set; }
        public string Extra0 { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Extra4 { get; set; }
        public string Extra5 { get; set; }
        public string Extra6 { get; set; }
        public string Extra7 { get; set; }
        public string Extra8 { get; set; }
        public string Extra9 { get; set; }
        public string SCHCargoSignBy { get; set; }
        public string HRemark { get; set; }
        public Nullable<int> MasterCarrier { get; set; }
        public string MasterCarrierCode { get; set; }
        public string MasterCarrierName { get; set; }
        public string OwnerUserID { get; set; }
        public string OwnerUserName { get; set; }
        public string OwnerStationID { get; set; }
        public string OwnerStationCode { get; set; }
        public Nullable<decimal> GWT_KG { get; set; }
        public Nullable<decimal> CWT_KG { get; set; }
        public string GoodsDescription { get; set; }
        public string OMSMoveType { get; set; }
        public Nullable<int> SPUnit { get; set; }
        public string SPUnitUOM { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonName { get; set; }
        public string ReasonDescription { get; set; }
        public string FLTPeriod { get; set; }
        public string TPSID { get; set; }
        public Nullable<int> TPHID { get; set; }
        public string HandlingCode { get; set; }
        public string HandlingCodeCategory { get; set; }
        public Nullable<decimal> FCLCBM { get; set; }
        public string CTNRType { get; set; }
        public string EAirPortCode { get; set; }
        public string EAirPortName { get; set; }
        public string IAirPortCode { get; set; }
        public string IAirPortName { get; set; }
        public string FlightRoute { get; set; }
        public string ConfirmID { get; set; }
        public string FCalculateType { get; set; }
        public Nullable<decimal> RevenueTon { get; set; }
        public string FreightPayType { get; set; }
        public string StrShiptype { get; set; }
        public string ClassRate { get; set; }
        public Nullable<double> Rate { get; set; }
        public Nullable<bool> IsCalculateInv { get; set; }
        public Nullable<int> ReasonMilestoneID { get; set; }
        public string ReasonMilestoneName { get; set; }
        public Nullable<System.DateTime> ReasonOccurrenceDate { get; set; }
    }
}