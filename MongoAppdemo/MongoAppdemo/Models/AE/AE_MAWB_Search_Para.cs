using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_MAWB_Search_Para : SearchParaBase
    {
        public String PartyType1 { get; set; }
        public String PartyType1Value { get; set; }

        public String PartyType2 { get; set; }
        public String PartyType2Value { get; set; }

        public String MAWBTypeValue { get; set; }

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

        public string DAWBURL { get; set; }

        public string MAWBNo { get; set; }

        public string LotNo { get; set; }

      
    }
}
