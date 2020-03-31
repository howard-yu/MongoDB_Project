using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel
{
    public class CityLookupPara : SearchParaBase
    {
        public string PL { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public string Country { get; set; }
        //2017/11/13 Andy Kang,merge autocomplet & lookup,VAL-562
        public string prefixText { get; set; }
        public int? Count { get; set; }
        public int? countryID { get; set; }
        public int? stateID { get; set; }
    }
}
