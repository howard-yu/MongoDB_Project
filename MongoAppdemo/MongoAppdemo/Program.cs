using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

using MongoDB.Bson.Serialization.Attributes;
//news
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;

using System.Net;
using System.Transactions;
using System.IO;
using Newtonsoft.Json;
using static MongoDB.Bson.Serialization.BsonDeserializationContext;
using System.Data.Entity;

namespace MongoAppdemo
{
    public class Program
    {
        private static MongoClient _mongoClient;
        private static MongoDatabaseBase _mongoDatabaseBase;
        private static MongoCollectionBase<SMAirLine> _mongoCollectionBase;


        static void Main(string[] args)
        {
            //Logmessage.WriteLog("Start Job by CSP Update");
            //Logmessage.ReadLog(DateTime.Now.ToString("yyyy-MM-dd"));
            //try
            //{
            //    updateNosql();
            //}
            //catch (Exception ex)

            //{
            //    Logmessage.WriteLog(ex.Message.ToString());
            //    Logmessage.ReadLog(DateTime.Now.ToString("yyyy-MM-dd"));
            //}
            testB();
        }

        static void updateNosql()
        {
            CSPEntities cdb = new CSPEntities();
            eChainVP_CentralEntities eChainVP_Central = new eChainVP_CentralEntities();

            List<CSPKeyValueForNoSQL> upnosql = new List<CSPKeyValueForNoSQL>();

            List<OPShipmentData> list = new List<OPShipmentData>();


            foreach (var item in eChainVP_Central.CSPKeyValueForNoSQL.Where(t => t.Flag == "0"))
            {
                item.Flag = "1";
            }
            eChainVP_Central.SaveChanges();


            var UpdateItem = eChainVP_Central.CSPKeyValueForNoSQL.Where(w => w.Flag == "1" || w.Flag == "0").Select(s => s).Distinct().ToList();


            if (UpdateItem.Count() > 0)
            {

                //UpdateItem.Add(new eChainVP_Central.CSPKeyValueForNoSQL{ })

                foreach (var item in UpdateItem)
                {
                    List<OPShipmentData> oplist = cdb.OPShipmentData.Where(w => w.KeyValue == item.KeyValue && w.PL == item.PL).ToList();

                    UpdateNoSql(oplist);

                    var CSP = eChainVP_Central.CSPKeyValueForNoSQL.Find(item.ID);

                    CSP.Flag = "2";
                    eChainVP_Central.Entry(CSP).State = EntityState.Modified;
                    eChainVP_Central.SaveChanges();
                }

                Logmessage.WriteLog("End Job by CSP Update");
                Logmessage.ReadLog(DateTime.Now.ToString("yyyy-MM-dd"));
            }
            else
            {
                Logmessage.WriteLog("No CSP Data need Update");
                Logmessage.ReadLog(DateTime.Now.ToString("yyyy-MM-dd"));
            }
        }

        public static void UpdateNoSql(List<OPShipmentData> oPList)
        {
            MongoHelper<OPShipmentData> OPShipmentDataHelper = new MongoHelper<OPShipmentData>();


            foreach (var oP in oPList)
            {
                List<FilterDefinition<OPShipmentData>> listFilter = new List<FilterDefinition<OPShipmentData>>()
                {
                    OPShipmentDataHelper.Filter.Eq(e=>e.KeyValue, oP.KeyValue),
                    OPShipmentDataHelper.Filter.Eq(e=>e.PL,oP.PL)
                };


                var query = OPShipmentDataHelper.Filter.Eq(p => p.KeyValue, oP.KeyValue);
                var count = OPShipmentDataHelper.Collection.Find(query).ToList().Count();


                if (count > 0)
                {


                    var updateDefinition = new List<UpdateDefinition<OPShipmentData>>()
                {
                    OPShipmentDataHelper.Update.Set(e=>e.IDType, oP.IDType),
                    OPShipmentDataHelper.Update.Set(e=>e.Status, oP.Status),
                    OPShipmentDataHelper.Update.Set(e=>e.MasterNo, oP.MasterNo),
                    OPShipmentDataHelper.Update.Set(e=>e.HouseNo, oP.HouseNo),
                    OPShipmentDataHelper.Update.Set(e=>e.ESkirtSID, oP.ESkirtSID),
                    OPShipmentDataHelper.Update.Set(e=>e.ESkirtHID, oP.ESkirtHID),
                    OPShipmentDataHelper.Update.Set(e=>e.ESkirtMID, oP.ESkirtMID),
                    OPShipmentDataHelper.Update.Set(e=>e.MStationID, oP.MStationID),
                    OPShipmentDataHelper.Update.Set(e=>e.EHubSID, oP.EHubSID),
                    OPShipmentDataHelper.Update.Set(e=>e.EHubHID, oP.EHubHID),
                    OPShipmentDataHelper.Update.Set(e=>e.IHubSID, oP.IHubSID),
                    OPShipmentDataHelper.Update.Set(e=>e.IHubHID, oP.IHubHID),
                    OPShipmentDataHelper.Update.Set(e=>e.ISkirtSID, oP.ISkirtSID),
                    OPShipmentDataHelper.Update.Set(e=>e.ISkirtHID, oP.ISkirtHID),
                    OPShipmentDataHelper.Update.Set(e=>e.ISkirtMID, oP.ISkirtMID),
                    OPShipmentDataHelper.Update.Set(e=>e.ISkirtMSID, oP.ISkirtMSID),
                    OPShipmentDataHelper.Update.Set(e=>e.ELotNo, oP.ELotNo),
                    OPShipmentDataHelper.Update.Set(e=>e.ILotNo, oP.ILotNo),
                    OPShipmentDataHelper.Update.Set(e=>e.CustomerID, oP.CustomerID),
                    OPShipmentDataHelper.Update.Set(e=>e.CustomerName, oP.CustomerName),
                    OPShipmentDataHelper.Update.Set(e=>e.Origin, oP.Origin),
                    OPShipmentDataHelper.Update.Set(e=>e.OriginCityCode, oP.OriginCityCode),
                    OPShipmentDataHelper.Update.Set(e=>e.OriginCityName, oP.OriginCityName),
                    OPShipmentDataHelper.Update.Set(e=>e.OriginCountryCode, oP.OriginCountryCode),
                    OPShipmentDataHelper.Update.Set(e=>e.OriginCountryName, oP.OriginCountryName),
                    OPShipmentDataHelper.Update.Set(e=>e.POL, oP.POL),
                    OPShipmentDataHelper.Update.Set(e=>e.POLCode, oP.POLCode),
                    OPShipmentDataHelper.Update.Set(e=>e.POLName, oP.POLName),
                    OPShipmentDataHelper.Update.Set(e=>e.POLCountryCode, oP.POLCountryCode),
                    OPShipmentDataHelper.Update.Set(e=>e.POLCountryName, oP.POLCountryName),
                    OPShipmentDataHelper.Update.Set(e=>e.POD, oP.POD),
                    OPShipmentDataHelper.Update.Set(e=>e.PODCode, oP.PODCode),
                    OPShipmentDataHelper.Update.Set(e=>e.PODName, oP.PODName),
                    OPShipmentDataHelper.Update.Set(e=>e.PODCountryCode, oP.PODCountryCode),
                    OPShipmentDataHelper.Update.Set(e=>e.PODCountryName, oP.PODCountryName),
                    OPShipmentDataHelper.Update.Set(e=>e.DSTN, oP.DSTN),
                    OPShipmentDataHelper.Update.Set(e=>e.DSTNCityCode, oP.DSTNCityCode),
                    OPShipmentDataHelper.Update.Set(e=>e.DSTNCityName, oP.DSTNCityName),
                    OPShipmentDataHelper.Update.Set(e=>e.DSTNCountryCode, oP.DSTNCountryCode),
                    OPShipmentDataHelper.Update.Set(e=>e.DSTNCountryName, oP.DSTNCountryName),
                    OPShipmentDataHelper.Update.Set(e=>e.Shipper, oP.Shipper),
                    OPShipmentDataHelper.Update.Set(e=>e.ShipperCode, oP.ShipperCode),
                    OPShipmentDataHelper.Update.Set(e=>e.ShipperName, oP.ShipperName),
                    OPShipmentDataHelper.Update.Set(e=>e.HouseShipperName, oP.HouseShipperName),
                    OPShipmentDataHelper.Update.Set(e=>e.HouseShipperAddr, oP.HouseShipperAddr),
                    OPShipmentDataHelper.Update.Set(e=>e.CNEE, oP.CNEE),
                    OPShipmentDataHelper.Update.Set(e=>e.CNEECode, oP.CNEECode),
                    OPShipmentDataHelper.Update.Set(e=>e.CNEEName, oP.CNEEName),
                    OPShipmentDataHelper.Update.Set(e=>e.HouseCNEEName, oP.HouseCNEEName),
                    OPShipmentDataHelper.Update.Set(e=>e.HouseCNEEAddr, oP.HouseCNEEAddr),
                    OPShipmentDataHelper.Update.Set(e=>e.Notify, oP.Notify),
                    OPShipmentDataHelper.Update.Set(e=>e.NotifyCode, oP.NotifyCode),
                    OPShipmentDataHelper.Update.Set(e=>e.NotifyName, oP.NotifyName),
                    OPShipmentDataHelper.Update.Set(e=>e.IssueDate, oP.IssueDate),
                    OPShipmentDataHelper.Update.Set(e=>e.ServiceLevel, oP.ServiceLevel),
                    OPShipmentDataHelper.Update.Set(e=>e.TradeTerm, oP.TradeTerm),
                    OPShipmentDataHelper.Update.Set(e=>e.Move, oP.Move),
                    OPShipmentDataHelper.Update.Set(e=>e.BookedFLT, oP.BookedFLT),
                    OPShipmentDataHelper.Update.Set(e=>e.OnBoardFLT, oP.OnBoardFLT),
                    OPShipmentDataHelper.Update.Set(e=>e.Vessel, oP.Vessel),
                    OPShipmentDataHelper.Update.Set(e=>e.Voyage, oP.Voyage),
                    OPShipmentDataHelper.Update.Set(e=>e.CWT, oP.CWT),
                    OPShipmentDataHelper.Update.Set(e=>e.CWTUOM, oP.CWTUOM),
                    OPShipmentDataHelper.Update.Set(e=>e.GWT, oP.GWT),
                    OPShipmentDataHelper.Update.Set(e=>e.GWTUOM, oP.GWTUOM),
                    OPShipmentDataHelper.Update.Set(e=>e.PCS, oP.PCS),
                    OPShipmentDataHelper.Update.Set(e=>e.PCSUOM, oP.PCSUOM),
                    OPShipmentDataHelper.Update.Set(e=>e.CBM, oP.CBM),
                    OPShipmentDataHelper.Update.Set(e=>e.TEU, oP.TEU),
                    OPShipmentDataHelper.Update.Set(e=>e.C20, oP.C20),
                    OPShipmentDataHelper.Update.Set(e=>e.C40, oP.C40),
                    OPShipmentDataHelper.Update.Set(e=>e.C40H, oP.C40H),
                    OPShipmentDataHelper.Update.Set(e=>e.C45, oP.C45),
                    OPShipmentDataHelper.Update.Set(e=>e.OtherCNTR, oP.OtherCNTR),
                    OPShipmentDataHelper.Update.Set(e=>e.CreatedDate, oP.CreatedDate),
                    OPShipmentDataHelper.Update.Set(e=>e.Remark, oP.Remark),
                    OPShipmentDataHelper.Update.Set(e=>e.DIMINV, oP.DIMINV),
                    OPShipmentDataHelper.Update.Set(e=>e.CTNRNo, oP.CTNRNo),
                    OPShipmentDataHelper.Update.Set(e=>e.PickAddr, oP.PickAddr),
                    OPShipmentDataHelper.Update.Set(e=>e.DELVAddr, oP.DELVAddr),
                    OPShipmentDataHelper.Update.Set(e=>e.PickPCS, oP.PickPCS),
                    OPShipmentDataHelper.Update.Set(e=>e.PickPCSUOM, oP.PickPCSUOM),
                    OPShipmentDataHelper.Update.Set(e=>e.PickWeight, oP.PickWeight),
                    OPShipmentDataHelper.Update.Set(e=>e.PickWeightUOM, oP.PickWeightUOM),
                    OPShipmentDataHelper.Update.Set(e=>e.ActualPickup, oP.ActualPickup),
                    OPShipmentDataHelper.Update.Set(e=>e.PickRemark, oP.PickRemark),
                    OPShipmentDataHelper.Update.Set(e=>e.VWT, oP.VWT),
                    OPShipmentDataHelper.Update.Set(e=>e.Volumn, oP.Volumn),
                    OPShipmentDataHelper.Update.Set(e=>e.Extra0, oP.Extra0),
                    OPShipmentDataHelper.Update.Set(e=>e.Extra1, oP.Extra1),
                    OPShipmentDataHelper.Update.Set(e=>e.Extra2, oP.Extra2),
                    OPShipmentDataHelper.Update.Set(e=>e.Extra3, oP.Extra3),
                    OPShipmentDataHelper.Update.Set(e=>e.Extra4, oP.Extra4),
                    OPShipmentDataHelper.Update.Set(e=>e.Extra5, oP.Extra5),
                    OPShipmentDataHelper.Update.Set(e=>e.Extra6, oP.Extra6),
                    OPShipmentDataHelper.Update.Set(e=>e.Extra7, oP.Extra7),
                    OPShipmentDataHelper.Update.Set(e=>e.Extra8, oP.Extra8),
                    OPShipmentDataHelper.Update.Set(e=>e.Extra9, oP.Extra9),
                    OPShipmentDataHelper.Update.Set(e=>e.SCHCargoSignBy, oP.SCHCargoSignBy),
                    OPShipmentDataHelper.Update.Set(e=>e.HRemark, oP.HRemark),
                    OPShipmentDataHelper.Update.Set(e=>e.MasterCarrier, oP.MasterCarrier),
                    OPShipmentDataHelper.Update.Set(e=>e.MasterCarrierCode, oP.MasterCarrierCode),
                    OPShipmentDataHelper.Update.Set(e=>e.MasterCarrierName, oP.MasterCarrierName),
                    OPShipmentDataHelper.Update.Set(e=>e.OwnerUserID, oP.OwnerUserID),
                    OPShipmentDataHelper.Update.Set(e=>e.OwnerUserName, oP.OwnerUserName),
                    OPShipmentDataHelper.Update.Set(e=>e.OwnerStationID, oP.OwnerStationID),
                    OPShipmentDataHelper.Update.Set(e=>e.OwnerStationCode, oP.OwnerStationCode),
                    OPShipmentDataHelper.Update.Set(e=>e.GWT_KG, oP.GWT_KG),
                    OPShipmentDataHelper.Update.Set(e=>e.CWT_KG, oP.CWT_KG),
                    OPShipmentDataHelper.Update.Set(e=>e.GoodsDescription, oP.GoodsDescription),
                    OPShipmentDataHelper.Update.Set(e=>e.OMSMoveType, oP.OMSMoveType),
                    OPShipmentDataHelper.Update.Set(e=>e.SPUnit, oP.SPUnit),
                    OPShipmentDataHelper.Update.Set(e=>e.SPUnitUOM, oP.SPUnitUOM),
                    OPShipmentDataHelper.Update.Set(e=>e.ReasonCode, oP.ReasonCode),
                    OPShipmentDataHelper.Update.Set(e=>e.ReasonName, oP.ReasonName),
                    OPShipmentDataHelper.Update.Set(e=>e.ReasonDescription, oP.ReasonDescription),
                    OPShipmentDataHelper.Update.Set(e=>e.FLTPeriod, oP.FLTPeriod),
                    OPShipmentDataHelper.Update.Set(e=>e.TPSID, oP.TPSID),
                    OPShipmentDataHelper.Update.Set(e=>e.TPHID, oP.TPHID),
                    OPShipmentDataHelper.Update.Set(e=>e.HandlingCode, oP.HandlingCode),
                    OPShipmentDataHelper.Update.Set(e=>e.HandlingCodeCategory, oP.HandlingCodeCategory),
                    OPShipmentDataHelper.Update.Set(e=>e.FCLCBM, oP.FCLCBM),
                    OPShipmentDataHelper.Update.Set(e=>e.CTNRType, oP.CTNRType),
                    OPShipmentDataHelper.Update.Set(e=>e.EAirPortCode, oP.EAirPortCode),
                    OPShipmentDataHelper.Update.Set(e=>e.EAirPortName, oP.EAirPortName),
                    OPShipmentDataHelper.Update.Set(e=>e.IAirPortCode, oP.IAirPortCode),
                    OPShipmentDataHelper.Update.Set(e=>e.IAirPortName, oP.IAirPortName),
                    OPShipmentDataHelper.Update.Set(e=>e.FlightRoute, oP.FlightRoute),
                    OPShipmentDataHelper.Update.Set(e=>e.ConfirmID, oP.ConfirmID),
                    OPShipmentDataHelper.Update.Set(e=>e.FCalculateType, oP.FCalculateType),
                    OPShipmentDataHelper.Update.Set(e=>e.RevenueTon, oP.RevenueTon),
                    OPShipmentDataHelper.Update.Set(e=>e.FreightPayType, oP.FreightPayType),
                    OPShipmentDataHelper.Update.Set(e=>e.StrShiptype, oP.StrShiptype),
                    OPShipmentDataHelper.Update.Set(e=>e.ClassRate, oP.ClassRate),
                    OPShipmentDataHelper.Update.Set(e=>e.Rate, oP.Rate),
                    OPShipmentDataHelper.Update.Set(e=>e.IsCalculateInv, oP.IsCalculateInv),
                    OPShipmentDataHelper.Update.Set(e=>e.ReasonMilestoneID, oP.ReasonMilestoneID),
                    OPShipmentDataHelper.Update.Set(e=>e.ReasonMilestoneName, oP.ReasonMilestoneName),
                    OPShipmentDataHelper.Update.Set(e=>e.ReasonOccurrenceDate, oP.ReasonOccurrenceDate)
                };

                    OPShipmentDataHelper.Collection.UpdateMany(OPShipmentDataHelper.Filter.And(listFilter),
                       OPShipmentDataHelper.Update.Combine(updateDefinition));
                }
                else
                {
                    OPShipmentDataHelper.Collection.InsertMany(oPList);
                }    
            }
        }

        static void testB()
        {
            CSPEntities odb = new CSPEntities();

            List<OPShipmentData> list = new List<OPShipmentData>();
            List<AllShipmentData> olist = new List<AllShipmentData>();

            //var bbb = odb.OPShipmentData.Where(w => w.CreatedDate.Year == 2020 && w.CreatedDate.Month == 2).Select(s => s).ToList();

            var aaa = (from ops in odb.OPShipmentData.Where(w => w.CreatedDate.Year == 2019 && w.CreatedDate.Month == 1).AsQueryable()
                       join opmf in odb.OPMilestoneFactData.AsQueryable()
                        on new { ops.KeyValue } 
                        equals new { opmf.KeyValue }
                        into details 
                        from opmf in details
                        select new
                        {
                                ops.OriginCityCode,
                                ops.DSTNCityCode,
                                ops.MasterNo,
                                ops.HouseNo,
                                ops.CTNRNo,
                                opmf.M100050,
                                opmf.M100,
                                opmf.M200,
                                opmf.M300,
                                opmf.M500,
                                opmf.M101150,
                                opmf.M900,
                                opmf.M1000,
                                opmf.M1050,
                                opmf.M1080,
                                opmf.M1090,
                                opmf.M1100,
                                opmf.M1200,
                                opmf.M1300,
                                opmf.M1310,
                                opmf.M1320,
                                opmf.M1330,
                                opmf.M1340,
                                opmf.M1350,
                                opmf.M1360,
                                opmf.M1400,
                                opmf.M1600,
                                opmf.M1700,
                                opmf.M1750,
                                opmf.M1800,
                                opmf.M1850,
                                opmf.M1900,
                                opmf.M2000,
                                opmf.M2100,
                                opmf.M2200,
                                opmf.M2300,
                                opmf.M2400,
                                opmf.M2500,
                                opmf.M2550,
                                opmf.M2600,
                                opmf.M2700,
                                opmf.M2800,
                                opmf.M2850,
                                opmf.M2900,
                                opmf.M105500,
                                opmf.M3000,
                                opmf.M3100,
                                opmf.M3200,
                                opmf.M3300,
                                opmf.M105900,
                                opmf.M3500,
                                opmf.M8000,
                                ops.CustomerID
                        }).ToList();


            foreach (var e in aaa)
            {
                AllShipmentData r = new AllShipmentData();
                r.PO = "";
                r.Origin = e.OriginCityCode;
                r.DSTN = e.DSTNCityCode;
                r.CTNR = e.CTNRNo;
                r.Master = e.MasterNo;
                r.House = e.HouseNo;
                r.ShippingInstructionReceivedFromSHPR = e.M100050 == null ? "" : e.M100050.ToString();
                r.CustomerTargetAvailableDate = e.M100 == null ? "" : e.M100.ToString();
                r.CustomerExpectedDepartureDate = e.M200 == null ? "" : e.M200.ToString();
                r.CustomerExpectedArrivalDate = e.M300 == null ? "" : e.M300.ToString();
                r.ODMBookingdate = "";
                r.BookingConfirmation = e.M500 == null ? "" : e.M500.ToString();
                r.Spaceconfirmdate = "";
                r.CYM = e.M101150 == null ? "" : e.M101150.ToString();
                r.ScheduledExfactoryDateatbookingformrequest = "";
                r.PickUpOrderToTrucker = "";
                r.ODMExfactoryDate = "";
                r.DocumentEstPickupDate = e.M900 == null ? "" : e.M900.ToString();
                r.DocumentActualPickupDate = e.M1000 == null ? "" : e.M1000.ToString();
                r.ActualArrivalDateTimeatAirport = "";
                r.AESFilingDateExportCustomsReleaseDate = e.M1050 == null ? "" : e.M1050.ToString();
                r.AEInvoiceIssued = e.M1080 == null ? "" : e.M1080.ToString();
                r.Estimatedtodepartwarehouseterminal = e.M1090 == null ? "" : e.M1090.ToString();
                r.ETD = e.M1100 == null ? "" : e.M1100.ToString();
                r.ATD = e.M1200 == null ? "" : e.M1200.ToString();
                r.ETA = e.M1300 == null ? "" : e.M1300.ToString();
                r.Actualtodepartwarehouseterminal = e.M1310 == null ? "" : e.M1310.ToString();
                r.CBSADescartesAcceptDate = e.M1320 == null ? "" : e.M1320.ToString();
                r.CBSADescartesRejectDate = e.M1330 == null ? "" : e.M1330.ToString();
                r.CBSACustomsRejectDate = e.M1340 == null ? "" : e.M1340.ToString();
                r.CBSACustomsAcceptDate = e.M1350 == null ? "" : e.M1350.ToString();
                r.CBSAFillingDate = e.M1360 == null ? "" : e.M1360.ToString();
                r.eManifestFirstSent = e.M1400 == null ? "" : e.M1400.ToString();
                r.MAWBePrealertFirstSent = e.M1600 == null ? "" : e.M1600.ToString();
                r.ePrealertFirstSent = e.M1700 == null ? "" : e.M1700.ToString();
                r.ExportLotClosed = e.M1750 == null ? "" : e.M1750.ToString();
                r.eManifestReceive = e.M1800 == null ? "" : e.M1800.ToString();
                r.PrealertReceive = e.M1850 == null ? "" : e.M1850.ToString();
                r.MAWBCreated = e.M1900 == null ? "" : e.M1900.ToString();
                r.DocumentPickup = e.M2000 == null ? "" : e.M2000.ToString();
                r.ATA = e.M2100 == null ? "" : e.M2100.ToString();
                r.ConsoleReleasedfromAirline = e.M2200 == null ? "" : e.M2200.ToString();
                r.CargoTransferFromTerminal = e.M2300 == null ? "" : e.M2300.ToString();
                r.DocumentDelivery = e.M2400 == null ? "" : e.M2400.ToString();
                r.ReleaseDate = e.M2500 == null ? "" : e.M2500.ToString();
                r.ArrivalNoticeSenttoCNEE = e.M2550 == null ? "" : e.M2550.ToString();
                r.NotifyBrokerofDocument = e.M2600 == null ? "" : e.M2600.ToString();
                r.TextileLicenseReadyDate = e.M2700 == null ? "" : e.M2700.ToString();
                r.CustomsClearanceDate = e.M2800 == null ? "" : e.M2800.ToString();
                r.StorageBeginDate = e.M2850 == null ? "" : e.M2850.ToString();
                r.DocumentReleaseDate = e.M2900 == null ? "" : e.M2900.ToString();
                r.CargoPickUpAirline = "";
                r.PlannedDateofDeliveryDate = "";
                r.ActualDateofDelivery = e.M105500 == null ? "" : e.M105500.ToString();
                r.FreightReleaseDate = e.M3000 == null ? "" : e.M3000.ToString();
                r.PODReceivedDate = e.M3100 == null ? "" : e.M3100.ToString();
                r.AIInvoiceIssued = e.M3200 == null ? "" : e.M3200.ToString();
                r.CargoClaimFromCNEE = e.M3300 == null ? "" : e.M3300.ToString();
                r.PreliminaryCargoClaimToCarrier = e.M105900 == null ? "" : e.M105900.ToString();
                r.CargoClaimSettlementDate = e.M3500 == null ? "" : e.M3500.ToString();
                r.CloseShipment = e.M8000 == null ? "" : e.M8000.ToString();
                r.CreatedDate = DateTime.Now;
                r.CustomerID = e.CustomerID.ToString();
                olist.Add(r);
            }

            //aaa.ToList().ForEach(e => olist.Add(new result {
            //    PO = "",
            //    Origin = e.OriginCityCode,
            //    DSTN = e.DSTNCityCode,
            //    CTNR = e.CTNRNo,
            //    Master = e.MasterNo,
            //    House = e.HouseNo,
            //    ShippingInstructionReceivedFromSHPR = e.M100050 == null ? "" : e.M100050.ToString(),
            //    CustomerTargetAvailableDate = e.M100 == null ? "" : e.M100.ToString(),
            //    CustomerExpectedDepartureDate = e.M200 == null ? "" : e.M200.ToString(),
            //    CustomerExpectedArrivalDate = e.M300 == null ? "" : e.M300.ToString(),
            //    ODMBookingdate = "",
            //    BookingConfirmation = e.M500 == null ? "" : e.M500.ToString(),
            //    Spaceconfirmdate = "",
            //    CYM = e.M101150 == null ? "" : e.M101150.ToString(),
            //    ScheduledExfactoryDateatbookingformrequest = "",
            //    PickUpOrderToTrucker = "",
            //    ODMExfactoryDate = "",
            //    DocumentEstPickupDate = e.M900 == null ? "" : e.M900.ToString(),
            //    DocumentActualPickupDate = e.M1000 == null ? "" : e.M1000.ToString(),
            //    ActualArrivalDateTimeatAirport = "",
            //    AESFilingDateExportCustomsReleaseDate = e.M1050 == null ? "" : e.M1050.ToString(),
            //    AEInvoiceIssued = e.M1080 == null ? "" : e.M1080.ToString(),
            //    Estimatedtodepartwarehouseterminal = e.M1090 == null ? "" : e.M1090.ToString(),
            //    ETD = e.M1100 == null ? "" : e.M1100.ToString(),
            //    ATD = e.M1200 == null ? "" : e.M1200.ToString(),
            //    ETA = e.M1300 == null ? "" : e.M1300.ToString(),
            //    Actualtodepartwarehouseterminal = e.M1310 == null ? "" : e.M1310.ToString(),
            //    CBSADescartesAcceptDate = e.M1320 == null ? "" : e.M1320.ToString(),
            //    CBSADescartesRejectDate = e.M1330 == null ? "" : e.M1330.ToString(),
            //    CBSACustomsRejectDate = e.M1340 == null ? "" : e.M1340.ToString(),
            //    CBSACustomsAcceptDate = e.M1350 == null ? "" : e.M1350.ToString(),
            //    CBSAFillingDate = e.M1360 == null ? "" : e.M1360.ToString(),
            //    eManifestFirstSent = e.M1400 == null ? "" : e.M1400.ToString(),
            //    MAWBePrealertFirstSent = e.M1600 == null ? "" : e.M1600.ToString(),
            //    ePrealertFirstSent = e.M1700 == null ? "" : e.M1700.ToString(),
            //    ExportLotClosed = e.M1750 == null ? "" : e.M1750.ToString(),
            //    eManifestReceive = e.M1800 == null ? "" : e.M1800.ToString(),
            //    PrealertReceive = e.M1850 == null ? "" : e.M1850.ToString(),
            //    MAWBCreated = e.M1900 == null ? "" : e.M1900.ToString(),
            //    DocumentPickup = e.M2000 == null ? "" : e.M2000.ToString(),
            //    ATA = e.M2100 == null ? "" : e.M2100.ToString(),
            //    ConsoleReleasedfromAirline = e.M2200 == null ? "" : e.M2200.ToString(),
            //    CargoTransferFromTerminal = e.M2300 == null ? "" : e.M2300.ToString(),
            //    DocumentDelivery = e.M2400 == null ? "" : e.M2400.ToString(),
            //    ReleaseDate = e.M2500 == null ? "" : e.M2500.ToString(),
            //    ArrivalNoticeSenttoCNEE = e.M2550 == null ? "" : e.M2550.ToString(),
            //    NotifyBrokerofDocument = e.M2600 == null ? "" : e.M2600.ToString(),
            //    TextileLicenseReadyDate = e.M2700 == null ? "" : e.M2700.ToString(),
            //    CustomsClearanceDate = e.M2800 == null ? "" : e.M2800.ToString(),
            //    StorageBeginDate = e.M2850 == null ? "" : e.M2850.ToString(),
            //    DocumentReleaseDate = e.M2900 == null ? "" : e.M2900.ToString(),
            //    CargoPickUpAirline = "",
            //    PlannedDateofDeliveryDate = "",
            //    ActualDateofDelivery = e.M105500 == null ? "" : e.M105500.ToString(),
            //    FreightReleaseDate = e.M3000 == null ? "" : e.M3000.ToString(),
            //    PODReceivedDate = e.M3100 == null ? "" : e.M3100.ToString(),
            //    AIInvoiceIssued = e.M3200 == null ? "" : e.M3200.ToString(),
            //    CargoClaimFromCNEE = e.M3300 == null ? "" : e.M3300.ToString(),
            //    PreliminaryCargoClaimToCarrier = e.M105900 == null ? "" : e.M105900.ToString(),
            //    CargoClaimSettlementDate = e.M3500 == null ? "" : e.M3500.ToString(),
            //    CloseShipment = e.M8000 == null ? "" : e.M8000.ToString(),
            //    CreatedDate = DateTime.Now
            //}));


            //list = odb.OPShipmentData.Where(w => w.CreatedDate.Year == 2020 && w.CreatedDate.Month == 3).Select(s => s).ToList();


            //var db = _mongoClient.GetDatabase("eChainVP");


            MongoHelper<AllShipmentData> OPShipmentDataHelper = new MongoHelper<AllShipmentData>();

            OPShipmentDataHelper.Collection.InsertMany(olist);

            //var doc = collection.AsQueryable().Where(x => x.HAWBNo == key).ToList();
            //int? dstn = 0;
            //foreach (var d in doc)
            //{
            //    Console.WriteLine(d.PortOfDSTN);
            //    dstn = d.PortOfDSTN;
            //}

            //var col = db.GetCollection<OPShipmentData>("OPShipmentData");
            //var DSTNCity = col.AsQueryable().Where(x => x.DSTN == dstn).FirstOrDefault().DSTNCityCode;
            //var DSTNCountryName = col.AsQueryable().Where(x => x.DSTN == dstn).FirstOrDefault().DSTNCountryName;

            //Console.WriteLine(DSTNCity);
            //Console.WriteLine(DSTNCountryName);
            //var news = testNews(DSTNCountryName);


            //Console.ReadLine();
        }

        static void testC()
        {
            //List<AirList> aList = new List<AirList>();
            var db = _mongoClient.GetDatabase("eChainVP");

            
            var col = db.GetCollection<OPShipmentData>("OPMilestoneData");

            //col.Indexes.CreateOne(Builders<OPShipmentData>.IndexKeys.Text(x => x.HouseNo));
            //col.Find(Builders<OPShipmentData>.Filter.Text("coffe")).ToList();
            //col.Indexes.CreateOne(new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.KeyValue)));


            //var list = col.Find(Builders<OPShipmentData>.Filter.Text("DIM027015987")).ToList();


     
         
            string[] indexs = {"ID",
"PL",
"KeyValue",
"IDType",
"Status",
"MasterNo",
"HouseNo",
"ESkirtSID",
"ESkirtHID",
"ESkirtMID",
"MStationID",
"EHubSID",
"EHubHID",
"IHubSID",
"IHubHID",
"ISkirtSID",
"ISkirtHID",
"ISkirtMID",
"ISkirtMSID",
"ELotNo",
"ILotNo",
"CustomerID",
"CustomerName",
"Origin",
"OriginCityCode",
"OriginCityName",
"OriginCountryCode",
"OriginCountryName",
"POL",
"POLCode",
"POLName",
"POLCountryCode",
"POLCountryName",
"POD",
"PODCode",
"PODName",
"PODCountryCode",
"PODCountryName",
"DSTN",
"DSTNCityCode",
"DSTNCityName",
"DSTNCountryCode",
"DSTNCountryName",
"Shipper",
"ShipperCode",
"ShipperName",
"HouseShipperName",
"HouseShipperAddr",
"CNEE",
"CNEECode",
"CNEEName",
"HouseCNEEName",
"HouseCNEEAddr",
"Notify",
"NotifyCode",
"NotifyName",
"IssueDate",
"ServiceLevel",
"TradeTerm",
"Move",
"BookedFLT",
"OnBoardFLT",
"Vessel",
"Voyage",
"CWT",
"CWTUOM",
"GWT",
"GWTUOM",
"PCS",
"PCSUOM",
"CBM",
"TEU",
"C20",
"C40",
"C40H",
"C45",
"OtherCNTR",
"CreatedDate",
"Remark",
"DIMINV",
"CTNRNo",
"PickAddr",
"DELVAddr",
"PickPCS",
"PickPCSUOM",
"PickWeight",
"PickWeightUOM",
"ActualPickup",
"PickRemark",
"VWT",
"Volumn",
"Extra0",
"Extra1",
"Extra2",
"Extra3",
"Extra4",
"Extra5",
"Extra6",
"Extra7",
"Extra8",
"Extra9",
"SCHCargoSignBy",
"HRemark",
"MasterCarrier",
"MasterCarrierCode",
"MasterCarrierName",
"OwnerUserID",
"OwnerUserName",
"OwnerStationID",
"OwnerStationCode",
"GWT_KG",
"CWT_KG",
"GoodsDescription",
"OMSMoveType",
"SPUnit",
"SPUnitUOM",
"ReasonCode",
"ReasonName",
"ReasonDescription",
"FLTPeriod",
"TPSID",
"TPHID",
"HandlingCode",
"HandlingCodeCategory",
"FCLCBM",
"CTNRType",
"EAirPortCode",
"EAirPortName",
"IAirPortCode",
"IAirPortName",
"FlightRoute",
"ConfirmID",
"FCalculateType",
"RevenueTon",
"FreightPayType",
"StrShiptype",
"ClassRate",
"Rate",
"IsCalculateInv",
"ReasonMilestoneID",
"ReasonMilestoneName",
"ReasonOccurrenceDate"};

            List<CreateIndexModel<OPShipmentData>> indexes = new List<CreateIndexModel<OPShipmentData>>();

            
            var ID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.ID));
            var PL = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.PL));
            var KeyValue = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.KeyValue));
            var IDType = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.IDType));
            var Status = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.Status));
            var MasterNo = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.MasterNo));
            var HouseNo = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.HouseNo));
            var ESkirtSID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.ESkirtSID));
            var ESkirtHID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.ESkirtHID));
            var ESkirtMID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.ESkirtMID));
            var MStationID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.MStationID));
            var EHubSID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.EHubSID));
            var EHubHID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.EHubHID));
            var IHubSID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.IHubSID));
            var IHubHID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.IHubHID));
            var ISkirtSID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.ISkirtSID));
            var ISkirtHID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.ISkirtHID));
            var ISkirtMID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.ISkirtMSID));
            var ISkirtMSID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.ISkirtMSID));
            var ELotNo = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.ELotNo));
            var ILotNo = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.ILotNo));
            var CustomerID = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.CustomerID));
            var CustomerName = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.CustomerName));
            var Origin = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.Origin));
            var OriginCityCode = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.OriginCityCode));
            var OriginCityName = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.OriginCityName));
            var OriginCountryCode = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.OriginCountryCode));
            var OriginCountryName = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.OriginCountryName));
            var POL = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.POL));
            var POLCode = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.POLCode));
            var POLName = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.POLName));
            var POLCountryCode = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.POLCountryCode));
            var POLCountryName = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.POLCountryName));
            var POD = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.POD));
            var PODCode = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.PODCode));
            var PODName = new CreateIndexModel<OPShipmentData>(Builders<OPShipmentData>.IndexKeys.Text(x => x.PODName));

            col.Indexes.CreateMany(indexes);

            var list = col.Find(Builders<OPShipmentData>.Filter.Text("1234")).ToList();


            Console.ReadLine();
        }

        static List<News> testNews(string query)
        {
            List<News> list = new List<News>();
            // init with your API key
            var newsApiClient = new NewsApiClient("7d413874ff4447e3bbaef43b932bb40b");
            
            var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                
                Q = query,
                SortBy = SortBys.Popularity,
                Language = Languages.ZH,
                From = new DateTime(2020, 2, 4)
            });
            if (articlesResponse.Status == Statuses.Ok)
            {

                // total results found
                Console.WriteLine(articlesResponse.TotalResults);
                // here's the first 20
                foreach (var article in articlesResponse.Articles)
                {
                    //title
                    Console.WriteLine(article.Title);
                    // author
                    Console.WriteLine(article.Author);
                    // description
                    Console.WriteLine(article.Description);
                    // url
                    Console.WriteLine(article.Url);
                    // image
                    Console.WriteLine(article.UrlToImage);
                    // published at
                    Console.WriteLine(article.PublishedAt);


                    list.Add(new News
                    {
                        Title = article.Title,
                        Author = article.Author,
                        Description = article.Description,
                        Url = article.Url,
                        UrlToImage = article.UrlToImage,
                        PublishedAt = article.PublishedAt.ToString()
                    });


                }
            }
            Console.ReadLine();
            return list;
        }

        public static goobay HttpGet(string url, Encoding encode = null)
        {
            goobay goodholidays = new goobay();
            string targetUrl = url;

            HttpWebRequest request = HttpWebRequest.Create(targetUrl) as HttpWebRequest;
            request.Method = "GET";
            request.ContentType = "application/json; charset=utf-8";
            request.Timeout = 30000;

            string result = "";
            // 取得回應資料
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {               
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                    goodholidays = JsonConvert.DeserializeObject<goobay>(result);
                }
            }

            return goodholidays;
            //string result;

            //try
            //{
            //    var webClient = new WebClient { Encoding = Encoding.UTF8 };

            //    if (encode != null)
            //        webClient.Encoding = encode;

            //    result = webClient.DownloadString(url);
            //}
            //catch (Exception ex)
            //{
            //    result = ex.Message;
            //}

            //return result;
        }
    }
    public struct AirList
    {
        List<SMAirLine> list { get; set; }
    }

    public struct SMAirLine
    {
        public string ID { get; set; }
        public string StationID { get; set; }
        public string keyValue { get; set; }
        public string Productline { get; set; }
        public string MilestoneID { get; set; }
        public string MilestoneTime { get; set; }
        public string IrrReason { get; set; }
        public string ApprovedBy { get; set; }
        public string ExtraValue1 { get; set; }
        public string ExtraValue2 { get; set; }
        public string UTCOffSet { get; set; }
        public string Status { get; set; }
        public string CreatedDT { get; set; }
        public string CreatedBy { get; set; }
        public string MilestoneCityCode { get; set; }
        public string MilestoneUTCTime { get; set; }
        public string CreatedUTCTime { get; set; }
    }

    public struct Articles
    {
        List<News> list { get; set; }
    }

    public struct News
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public string PublishedAt { get; set; }
    }

    public struct goobay
    {
        public string status { get; set; }
        public string warning { get; set; }
        public requests requests { get; set; }
        public List<holidays> holidays { get; set; }
    }

    public struct requests
    {
        public string used { get; set; }
        public string available { get; set; }
        public string resets { get; set; }
    }

    public struct holidays
    {
        public string name { get; set; }
        public string date { get; set; }
        public string observed { get; set; }
        public string Public { get; set; }
        public string country { get; set; }
        public string uuid { get; set; }
        public weekday Weekday { get; set; }
    }

    public struct weekday
    {
        public date date { get; set; }
        public observed observed { get; set; }
    }

    public struct date
    {
        public string name { get; set; }
        public string numeric { get; set; }
    }

    public struct observed
    {
        public string name { get; set; }
        public string numeric { get; set; }
    }

    public struct Article
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public int? RepprintSourceUrl { get; set; }
        public bool IsChoiceness { get; set; }
        public string ChannelId {get;set;}
        public Double MachineAuditRate { get; set; }
        public string Tags { get; set;  }
        public int CommentsCount { get; set; }
        public int FavoritesCount { get; set; }
        public int ViewCount { get; set; }
        public string[] Keywords { get; set; }
    }

    public class searchFileByAuthor
    {
        public int Id { get; set; }
        public string subject { get; set; }
    }

    public struct AllShipmentData
    {
        public string PO { get; set; }
        public string Origin { get; set; }
        public string DSTN { get; set; }
        public string Master { get; set; }
        public string House { get; set; }
        public string CTNR { get; set; }
        public string ShippingInstructionReceivedFromSHPR { get; set; }
        public string CustomerTargetAvailableDate { get; set; }
        public string CustomerExpectedDepartureDate { get; set; }
        public string CustomerExpectedArrivalDate { get; set; }
        public string ODMBookingdate { get; set; }
        public string BookingConfirmation { get; set; }
        public string Spaceconfirmdate { get; set; }
        public string CYM { get; set; }
        public string ScheduledExfactoryDateatbookingformrequest { get; set; }
        public string PickUpOrderToTrucker { get; set; }
        public string ODMExfactoryDate { get; set; }
        public string DocumentEstPickupDate { get; set; }
        public string DocumentActualPickupDate { get; set; }
        public string ActualArrivalDateTimeatAirport { get; set; }
        public string AESFilingDateExportCustomsReleaseDate { get; set; }
        public string AEInvoiceIssued { get; set; }
        public string Estimatedtodepartwarehouseterminal { get; set; }
        public string ETD { get; set; }
        public string ATD { get; set; }
        public string ETA { get; set; }
        public string Actualtodepartwarehouseterminal { get; set; }
        public string CBSADescartesAcceptDate { get; set; }
        public string CBSADescartesRejectDate { get; set; }
        public string CBSACustomsRejectDate { get; set; }
        public string CBSACustomsAcceptDate { get; set; }
        public string CBSAFillingDate { get; set; }
        public string eManifestFirstSent { get; set; }
        public string MAWBePrealertFirstSent { get; set; }
        public string ePrealertFirstSent { get; set; }
        public string ExportLotClosed { get; set; }
        public string eManifestReceive { get; set; }
        public string PrealertReceive { get; set; }
        public string MAWBCreated { get; set; }
        public string DocumentPickup { get; set; }
        public string ATA { get; set; }
        public string ConsoleReleasedfromAirline { get; set; }
        public string CargoTransferFromTerminal { get; set; }
        public string DocumentDelivery { get; set; }
        public string ReleaseDate { get; set; }
        public string ArrivalNoticeSenttoCNEE { get; set; }
        public string NotifyBrokerofDocument { get; set; }
        public string TextileLicenseReadyDate { get; set; }
        public string CustomsClearanceDate { get; set; }
        public string StorageBeginDate { get; set; }
        public string DocumentReleaseDate { get; set; }
        public string CargoPickUpAirline { get; set; }
        public string PlannedDateofDeliveryDate { get; set; }
        public string ActualDateofDelivery { get; set; }
        public string FreightReleaseDate { get; set; }
        public string PODReceivedDate { get; set; }
        public string AIInvoiceIssued { get; set; }
        public string CargoClaimFromCNEE { get; set; }
        public string PreliminaryCargoClaimToCarrier { get; set; }
        public string CargoClaimSettlementDate { get; set; }
        public string CloseShipment { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CustomerID { get; set; }
    }
}
