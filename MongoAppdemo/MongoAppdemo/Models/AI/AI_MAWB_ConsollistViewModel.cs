using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWB_ConsollistViewModel:ViewModelBase
    {
        public int ID { get; set; }
        public string HAWBNo { get; set; }
        //public string ServiceLevel { get; set; }
        //public string Customer { get; set; }
        public string Shipper { get; set; }
        public string CNEE { get; set; }
        public string PlaceOfRCPT { get; set; }
        public string PortOfDSTN { get; set; }
        public string PlaceOfDELV { get; set; }
        public string PortOfDEPT { get; set; }
        public string PreAlertUser { get; set; }
        public DateTime? PreAlertDate { get; set; }
        public string ActPCSUOM { get; set; }
        public int? ActPCS { get; set; }
        public double? CWT { get; set; }
        public double? VWT { get; set; }
        public double ? GWT { get; set; }
        public string WTUOM { get; set; }
        public string AWBType { get; set; }
        //public int SH { get; set; }
        public string Status { get; set; }
        public string StationID { get; set; }
        public string FinalImport { get; set; }
        public string Remark { get; set; }
        public string NatureOfGoods { get; set; }
       // public string SalesCostUrl { get; set; }
        public string HAWBNoUrl { get; set; }
        public string B { get; set; }
        public string eMailPreAlert { get; set; }
        


    }
}
