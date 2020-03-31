using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_BookingViewModel : ViewModelBase
    {
        public int ID { get; set; }

        [Key]
        public int HAWBID { get; set; }

        

        [StringLength(50)]
        public string ServiceLevel { get; set; }
        [StringLength(50)]
        public string DocType { get; set; }
        [StringLength(1)]
        public string BookSend { get; set; }
        [StringLength(50)]
        public string LoadStation1 { get; set; }
        public List<DDLViewModel> LoadStationList { get; set; }
        public int? BookingPCS { get; set; }
        [StringLength(10)]
        public string BookingPCSUOM { get; set; }
        [StringLength(100)]
        public string ShipperLocalName { get; set; }
        [StringLength(10)]
        public string Area { get; set; }
        [StringLength(50)]
        public string CS { get; set; }
        public decimal? BookingGWT { get; set; }
        [StringLength(10)]
        public string BookingWTUOM { get; set; }
        [StringLength(50)]
        public string Rate { get; set; }
        [StringLength(100)]
        public string LocalCommodity { get; set; }
        public decimal? BookingVolume { get; set; }
        [StringLength(10)]
        public string BookingVolumeUOM { get; set; }
        [StringLength(200)]
        public string Remark { get; set; }
        [StringLength(200)]
        public string ShipingRemark { get; set; }

        //Below is for Load
        [StringLength(50)]
        public string LoadMasterLoader1 { get; set; }
        [StringLength(50)]
        public string LoadCarrier1 { get; set; }
        [StringLength(50)]
        public string LoadMAWBNo1 { get; set; }
        /// <summary>
        /// No use in 2.0
        /// </summary>
        public string ETD { get; set; }
        [StringLength(50)]
        public string LoadFLTNo1 { get; set; }
        [StringLength(50)]
        public string LoadTerminal1 { get; set; }
        [StringLength(50)]
        public string CSStatus { get; set; }


        //Below is used for other

    }
}

