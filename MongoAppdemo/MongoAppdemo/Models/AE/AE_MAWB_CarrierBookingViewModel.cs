using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_MAWB_CarrierBookingViewModel : ViewModelBase
    {
        public int? ID { get; set; }

        public int? MAWBID { get; set; }

        [Required]
        [UIHint("MAWBCarrierBook_DeptTemplete")]
        public int DEPT { get; set; }

        public string DEPTCode { get; set; }

        [Required]
        [UIHint("MAWBCarrierBook_DstnTemplete")]
        public int DSTN { get; set; }

        public string DSTNCode { get; set; }

        //Add by Rou @2019/3/13 , add a reminder maseeage
        [Required]
        [StringLength(20, ErrorMessage = "MaxLength 20")]
        public string BookedFLT { get; set; }

        //Add by Rou @2019/3/13 , add a reminder maseeage
        [Required]
        [StringLength(20, ErrorMessage = "MaxLength 20")]
        public string OnboardFLT { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [UIHint("GridDateTemplate")]
        public DateTime? ETD { get; set; }
        [UIHint("GridTimeTemplate")]
        public string ETDTime { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [UIHint("GridDateTemplate")]
        public DateTime? ETA { get; set; }
        [UIHint("GridTimeTemplate")]
        public string ETATime { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [UIHint("GridDateTemplate")]
        public DateTime? ATA { get; set; }
        [UIHint("GridTimeTemplate")]
        public string ATATime { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [UIHint("GridDateTemplate")]
        public DateTime? ATD { get; set; }
        [UIHint("GridTimeTemplate")]
        public string ATDTime { get; set; }

        public string StationID { get; set; }

        public string CreateBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(8)]
        [Timestamp]
        public byte[] Version { get; set; }

        [UIHint("GridIntegerTemplate")]
        public int? PCS { get; set; }

        [UIHint("GridNumberTemplate")]
        public double? GWT { get; set; }

        [UIHint("GridNumberTemplate")]
        public double? VWT { get; set; }

        [UIHint("GridNumberTemplate")]
        public double? CWT { get; set; }

        public int? SourceID { get; set; }

        //Update by Bill @ 2019-01-11 To mark CarrierBooking is Splited. VAL-1676
        public bool? IsSplit { get; set; }

        public int? CarrierFrom { get; set; }
    }
}
