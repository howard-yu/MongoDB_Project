using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_ConsollistViewModel : ViewModelBase
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
        public string PCS { get; set; }
        public string CWT { get; set; }
        public double? VWT { get; set; }
        public double? GWT { get; set; }
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

        public string Consol { get; set; }
        public string Order { get; set; }
        public string Delivery { get; set; }
        public string TruckCompany { get; set; }
        public string Pickupfrom { get; set; }
        public string Pickup { get; set; }
        public string ActualPickup{ get; set; }

        public string FLTNo { get; set; }
        public DateTime? LandingDate { get; set; }



        public string eMailPreAlert { get; set; }



    }
}
