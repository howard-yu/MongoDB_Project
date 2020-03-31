using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICenter.Areas.CSP.Models
{
    [BsonIgnoreExtraElements]
    public class AllShipmentData
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