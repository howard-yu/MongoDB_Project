using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    /// Update by Royal @ 2019/4/3 To fix did not validate issuedate when save,VAL-2110

    //update by Royal @ 2019/4/3 DAWB check point different with MAWB, cloud not carry on AE_MAWB_HeaderViewModel
    //public class AE_DAWB_HeaderViewModel : AE_MAWB_HeaderViewModel
    public class AE_DAWB_HeaderViewModel : ViewModelBase
    {
       
  
        public int? DAWBID { get; set; }
        [Required(ErrorMessage = "Customer is mandatory")]
        public int? customerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }

        public string DAWBNo { get; set; }
        public string IssuerName { get; set; }
        public string BookingNo { get; set; }
        public string ServiceLevel { get; set; }
        public string handlingcodeCategory { get; set; }
        public string handlingcodeItem { get; set; }
        public string oneTimeOnly { get; set; }
        public string milestone { get; set; }
        public string DAWBLog { get; set; }

        public bool CustomerRead { get; set; }
        public bool ServiceLevelRead { get; set; }
        public bool DAWBNoRead { get; set; }
        public bool IssueDateRead { get; set; }
        public bool HandlingCodeCategoryRead { get; set; }
        public string HAWBNo { get; set; }

        //add by Royal @ 2019/4/3 DAWB check point different with MAWB, so add parameter
        public string MAWBNo { get; set; }
        public string MAWBLotNo { get; set; }
        public int? MAWBType { get; set; }
        public int? IssuerID { get; set; }
        public string IssuerCode { get; set; }
        public int? IssueCityID { get; set; }
        public string IssueCityCode { get; set; }
        [Required(ErrorMessage = "IssueDate is mandatory")]
        public DateTime? IssueDate { get; set; }
        public DateTime? sendAMSDate { get; set; }
        public string sendAMSBy { get; set; }
        public bool issuerRead { get; set; }
        public bool issuerTypeRead { get; set; }
        public bool mawbTypeRead { get; set; }
        public bool issueCityRead { get; set; }
        public bool mawbNoRead { get; set; }
        public string sendAMSInfo { get; set; }
        public string ShptType { get; set; }
        public string CurrentMilestone { get; set; }
        public string NextMilestone { get; set; }
    }
}
