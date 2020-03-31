using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_Search_Para : SearchParaBase
    {
        public String PartyType1 { get; set; }
        public String PartyType1Value { get; set; }

        public String PartyType2 { get; set; }
        public String PartyType2Value { get; set; }

        public String DateType { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public String StatusValue { get; set; }

        public String PlaceType { get; set; }
        public String PlaceValue { get; set; }

        public String OfficeValue { get; set; }

        public String NumberType { get; set; }
        public String NumberValue { get; set; }

        public String ViewType { get; set; }
        public String SalesValue { get; set; }

        public String TradeTermValue { get; set; }

        public int HAWBID { get; set; }

        public int? ID { get; set; }

        public string MAWBNo { get; set; }

        public string AWBType { get; set; }

        public string HAWBNo { get; set; }

        public string HawbNoUrl { get; set; }

        public string MTSNo { get; set; }

        public string StationID { get; set; }

        public string PreAlertUser { get; set; }

        public DateTime? PreAlertDate { get; set; }

        public string SHPR { get; set; }

        public string CNEE { get; set; }

        public string CUST { get; set; }

        public string ThirdPT { get; set; }

        public string PortOfDSTN { get; set; }

        public string PortOfDEPT { get; set; }

        public string PlaceofRECP { get; set; }

        public string PlaceofDELV { get; set; }

        public string PCSUOM { get; set; }

        public string GWTUOM { get; set; }

        public string CWTUOM { get; set; }

        public string PCS { get; set; }

        public string GWT { get; set; }

        public string CWT { get; set; }

        public string INST { get; set; }

        public string Bill { get; set; }

        public string PreAlertTime { get; set; }

        public string LotNo { get; set; }

        public string Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public string StationCode { get; set; }

        public string MStationCode { get; set; }

        public string ParentAWBType { get; set; }

        public string LotNoStationCode { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ATA { get; set; }
        public string SPINST { get; set; }
        public DateTime? AvailPickup { get; set; }
        public string SI { get; set; }
        public string B { get; set; }
        public string SALES { get; set; }
        public string TradeTerm { get; set; }
        public string PlaceOfRCPT { get; set; }
        public string Delivery { get; set; }
        public string CreatedBy { get; set; }
        public string Delivery_Order { get; set; }
        public string TRADE { get; set; }
    }
}
