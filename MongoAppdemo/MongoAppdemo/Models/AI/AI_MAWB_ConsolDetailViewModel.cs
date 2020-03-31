using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWB_ConsolDetailViewModel : ViewModelBase
    {
        [Required]
        public int? PortOfDeptID { get; set; }

        public string PortOfDeptCode { get; set; }

        [Required]
        public int? PortOfDstnID { get; set; }

        public string PortOfDstnCode { get; set; }
        //Add by Jane at 2019/10/16 add AirPortOfDEPT/AirPortOfDSTN, VAL-1740
        public int? AirPortOfDeptID { get; set; }

        public string AirPortOfDept { get; set; }

        public int? AirPortOfDstnID { get; set; }

        public string AirPortOfDstn { get; set; }

        [Required]
        public int? SHPRID { get; set; }

        public string SHPRCode { get; set; }

        public int? ColoadID { get; set; }

        public string ColoadCode { get; set; }

        [Required]
        public int? CNEEID { get; set; }

        public string CNEECode { get; set; }

        public int? NTFYID { get; set; }

        public string NTFYCode { get; set; }

        public int? PCS { get; set; }

        public double? GWT { get; set; }

        public double? CWT { get; set; }

        public double? VWT { get; set; }

        public string WTUOM { get; set; }  

        public double? Show { get; set; }

        public string FRT { get; set; }

        public string RateClass { get; set; }   
        
        public double? DIM { get; set; }    

        public string DIMUOM { get; set; }
    }
}
