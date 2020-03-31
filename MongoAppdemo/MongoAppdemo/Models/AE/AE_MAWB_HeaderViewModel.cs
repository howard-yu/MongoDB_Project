using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    //Add by Bill @ 2018//08/29 VAL-1085 show shipment info
    public class AE_MAWB_HeaderViewModel : ViewModelBase
    {
        [Required(ErrorMessage = "MAWBNo is mandatory")]
        public string MAWBNo { get; set; }
        public int? MAWBType { get; set; }
        public string MAWBTypeCode { get; set; }
        //[Required(ErrorMessage = "Issuer is mandatory")]
        public int? IssuerID { get; set; }
        public string IssuerCode { get; set; }
        public int? IssueCityID { get; set; }
        public string IssueCityCode { get; set; }
        [Required(ErrorMessage = "IssueDate is mandatory")]
        public DateTime? IssueDate { get; set; }
        public string MAWBLotNo { get; set; }
        public string issueType { get; set; }
        public string issueTypeCode { get; set; }

        public DateTime? sendAMSDate { get; set; }
        public string sendAMSBy { get; set; }
        public string sendAMSInfo { get; set; }
        public string updateInfo { get; set; }
        #region ReadOnly Operation

        public bool issuerRead { get; set; }
        public bool issuerTypeRead { get; set; }
        public bool mawbTypeRead { get; set; }
        public bool issueCityRead { get; set; }
        public bool mawbNoRead { get; set; }

        #endregion

        //Add by Bill @ 2018//08/29 VAL-1085 show shipment info
        public string ShptType { get; set; }
        public string CurrentMilestone { get; set; }
        public string NextMilestone { get; set; }
    }
}
