using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

using MongoDB.Driver;
using APICenter.Areas.CSP.Models;
using MongoDB.Bson;

using System.Text.RegularExpressions;

namespace APICenter.Areas.CSP.Controllers
{
    public class CSPController : ApiController
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult getCSP(CSPPara para)
        {
            //MongoHelper<OPShipmentData> OPHelper = new MongoHelper<OPShipmentData>();
            //MongoHelper<OPMilestoneData> OPMHelper = new MongoHelper<OPMilestoneData>();
            MongoHelper<AllShipmentData> AllOPHelper = new MongoHelper<AllShipmentData>();

            //List<OPShipmentData> oplist = new List<OPShipmentData>();

            //List<OPMilestoneData> opmlist = new List<OPMilestoneData>();

            List<AllShipmentData> allpmlist = new List<AllShipmentData>();


            if (string.IsNullOrEmpty(para.value))
            {
                allpmlist = AllOPHelper.Collection.Find(w => w.CustomerID == para.projectid).ToList();
            }
            else
            {
                var notificationLogBuilder = Builders<AllShipmentData>.IndexKeys;

                var indexModel = Builders<AllShipmentData>.IndexKeys.Combine(
                    Builders<AllShipmentData>.IndexKeys.Ascending(f => f.DSTN),
                    Builders<AllShipmentData>.IndexKeys.Ascending(f => f.House),
                    Builders<AllShipmentData>.IndexKeys.Ascending(f => f.Master),
                    Builders<AllShipmentData>.IndexKeys.Ascending(f => f.CTNR),
                    Builders<AllShipmentData>.IndexKeys.Ascending(f => f.Origin)
                );
                AllOPHelper.Collection.Indexes.CreateOneAsync(new CreateIndexModel<AllShipmentData>(indexModel));

                allpmlist = AllOPHelper.Collection.Find(Builders<AllShipmentData>.Filter.Where(
                    f => f.CustomerID == para.projectid &&
                    f.CTNR.Contains(para.value) ||
                    f.Origin.Contains(para.value) ||
                    f.House.Contains(para.value) ||
                    f.Master.Contains(para.value) ||
                    f.DSTN.Contains(para.value)
                )).ToList();        
            }

            //paging
            int total = allpmlist.Count();
            int page = para.Page == 0 ? 1 : para.Page;
            int count = para.Count == 0 ? total : para.Count;
            allpmlist = allpmlist.OrderByDescending(e => e.CreatedDate).Skip((page - 1) * count).Take(count).ToList();

            return Ok(new
            {
                total,
                page,
                count,
                data = allpmlist,  
            });
        }

        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult getByProJectid(fillterCustomerID para)
        {
            MongoHelper<OPShipmentData> OPHelper = new MongoHelper<OPShipmentData>();

            var list = OPHelper.Collection.Find(w => w.CustomerID == Convert.ToInt32(para.projectid)).ToList();
            int total = list.Count();
            int page = para.Page == 0 ? 1 : para.Page;
            int count = para.Count == 0 ? total : para.Count;
            list = list.OrderByDescending(e => e.CreatedDate).Skip((page - 1) * count).Take(count).ToList();

            return Ok(new
            {
                total,
                page,
                count,
                data = list,
            });
        }

        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult getAll(CSPPara para)
        {
            MongoHelper<OPShipmentData> OPHelper = new MongoHelper<OPShipmentData>();

            //string p = para.projectid == null ? $".*{Regex.Escape("")}.*" : $".*{Regex.Escape(para.projectid)}.*";
            //OPHelper.Collection.Find(Builders<OPShipmentData>.Filter.Regex("CustomerID", new BsonRegularExpression(new Regex(p, RegexOptions.IgnoreCase))));

            //var query = new QueryMongoParameter<NewsContentDto>(parameter, "news_content", filter2);
            //var ret = await MongoContext.PagerQueryAsync(query);


            //var query = Query<OPShipmentData>.Matches(c => c.Title, new BsonRegularExpression(new Regex("*.txt")));
            string p = para.projectid == null ? $".*{Regex.Escape("")}.*" : $".*{Regex.Escape(para.projectid)}.*";
            var filter = Builders<OPShipmentData>.Filter.Regex(x => x.KeyValue, new BsonRegularExpression(new Regex(p, RegexOptions.IgnoreCase)));
            var document = OPHelper.Collection.Find(filter).ToList();
            //var Filter = new BsonDocument("CustomerID", Convert.ToInt32(para.projectid));
            //var document = OPHelper.Collection
            //                            emit(this.KeyValue, this.PL);
            //                        };";

            //string reduceFunction = @"function(KeyValue, PL){
            //                            var total = 0;
            //                            total = Array.sum(KeyValue);
            //                            return { sum: total };
            //                        };";

            //var options = 
            //options.SetFinalize(finalize);
            //options.SetOutput(MapReduceOutput.Inline);

            //var cusid_prices_results = OPHelper.Collection.MapReduce(map: mapFunction,reduce:reduceFunction);
            return Ok(new
            {
                data = document,
            });
        }
    }
    public struct CSPPara
    {
        public string projectid { get; set; }
        public string value { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
    }

    public struct fillterCustomerID
    {
        public string projectid { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
    }

    public struct result
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
    }
}
  