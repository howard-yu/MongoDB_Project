using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWB_Search_Para : SearchParaBase
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

        public String SortBy { get; set; }

        public int? MAWBType { get; set; }
        public int? ID { get; set; }
        public String MAWBNo { get; set; }
        public String MawbNoUrl { get; set; }
        public String StationID { get; set; }
        public String LotNo { get; set; }
        public String PortOfDSTN { get; set; }
        public String PortOfDEPT { get; set; }
        public String Shipper { get; set; }
        public String CNEE { get; set; }
        public String CARR { get; set; }
        public String GWT { get; set; }
        public String CWT { get; set; }
        public String SPINST { get; set; }
        public String Status { get; set; }
        public String StationCode { get; set; }
        public String CreatedBy { get; set; }
        public string Bill { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ATA { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string B { get; set; }


    }
}
