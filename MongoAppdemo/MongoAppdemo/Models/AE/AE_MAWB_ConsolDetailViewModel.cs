using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    //Update by Jane at 2019/12/19 Control DEPT/DSTN Airport is mandatory, VAL-3799
    public class AE_MAWB_ConsolDetailViewModel : ViewModelBase
    {

        [Required]
        [Range(1, 99999999, ErrorMessage = "DEPT is mandatory")]
        public int? PortOfDeptID { get; set; }

        public string PortOfDeptCode { get; set; }
        [Required]
        [Range(1, 99999999, ErrorMessage = "DSTN is mandatory")]
        public int? PortOfDstnID { get; set; }

        public string PortOfDstnCode { get; set; }
        //Update by Jane at 2019/12/19 Control DEPT/DSTN Airport is mandatory, VAL-3799
        [Required(ErrorMessage = "DEPT Airport is mandatory")]
        public int? AirPortOfDeptID { get; set; }
        
        public string AirPortOfDept { get; set; }
        [Required(ErrorMessage = "DSTN Airport is mandatory")]
        public int? AirPortOfDstnID { get; set; }
        
        public string AirPortOfDstn { get; set; }

        [Required]
        [Range(1,99999999, ErrorMessage = "SHPR is mandatory")]
        public int? SHPRID { get; set; }

        public string SHPRCode { get; set; }

        [Required]
        [Range(1,99999999,ErrorMessage ="CNEE is mandatory")]
        public int? CNEEID { get; set; }

        public string CNEECode { get; set; }

        public int? NTFYID { get; set; }

        public string NTFYCode { get; set; }

        public string PayType { get; set; }

        public string FRT { get; set; }

        public int? SPL { get; set; }

        public string SPLCode { get; set; }

        public string Other { get; set; }

        public int? PCS { get; set; }

        public double? GWT { get; set; }

        public double? CWT { get; set; }

        public double? VWT { get; set; }

        public string WTUOM { get; set; }

        //Add by Rou @2019/3/13 , add a reminder maseeage
        [StringLength(255)]
        public string PackageDescription { get; set; }

        public string Currency { get; set; }

        public double? Show { get; set; }

        public double? ShowM { get; set; }

        public double? CTCT { get; set; }

        public double? CTCTM { get; set; }

        public double? COMM { get; set; }

        public double? ExCOMM { get; set; }

        public string RateClass { get; set; }

        public double? Cost { get; set; }

        public double? Net { get; set; }

        public double? DIM { get; set; }

        public string DIMUOM { get; set; }

        public string HandlingInfo { get; set; }
        public string HandlingInfoColor { get; set; }

        //add by Howard @ 2019/08/07 VAL2744
        public bool? IsNumberForCustomsClearancePrice { get; set; }

        #region ReadOnly Operation

        public bool cTCTRead { get; set; }
        public bool showRead { get; set; }      

        #endregion
    }
}
