using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_HAWB_BookingViewModel : ViewModelBase
    {
        public int ID { get; set; }

        [Key]
        public int HAWBID { get; set; }

        

        public string ServiceLevel { get; set; }

        public string DocType { get; set; }

        public string BookSend { get; set; }

        public string LoadStation1 { get; set; }
        public List<DDLViewModel> LoadStationList { get; set; }
        public int? BookingPCS { get; set; }
        public string BookingPCSUOM { get; set; }
        public string ShipperLocalName { get; set; }

        public string Area { get; set; }
        public string CS { get; set; }

        public decimal? BookingGWT { get; set; }


        public string BookingWTUOM { get; set; }

        public string Rate { get; set; }

        public string LocalCommodity { get; set; }


        public decimal? BookingVolume { get; set; }

        public string BookingVolumeUOM { get; set; }

        public string Remark { get; set; }
        
        public string ShipingRemark { get; set; }


        public string LoadMasterLoader1 { get; set; }


        public string LoadCarrier1 { get; set; }

        public string LoadMAWBNo1 { get; set; }
        /// <summary>
        /// No use in 2.0
        /// </summary>
        public string ETD { get; set; }

        public string LoadFLTNo1 { get; set; }

        public string LoadTerminal1 { get; set; }

        public string CSStatus { get; set; }


        //Below is used for other

    }
}

