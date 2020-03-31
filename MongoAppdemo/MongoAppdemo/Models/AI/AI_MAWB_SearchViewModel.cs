using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWB_SearchViewModel : SearchResultBase
    {
        public int? ID { get; set; }
        public string MAWBNo { get; set; }
        public string MawbNoUrl { get; set; }
        public string StationID { get; set; }
        public string LotNo { get; set; }
        public string PortOfDSTN { get; set; }
        public string PortOfDEPT { get; set; }
        public string Shipper { get; set; }
        public string CNEE { get; set; }
        public string Carrier { get; set; }
        public int? PCS { get; set; }
        public int? HNo { get; set; }
        public decimal? GP { get; set; }
        public string GWT { get; set; }
        public string CWT { get; set; }
        public string SPINST { get; set; }
        public string Status { get; set; }
        public string StationCode { get; set; }
        public string CreatedBy { get; set; }
        public string Bill { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ATA { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string B { get; set; }
    }
}
