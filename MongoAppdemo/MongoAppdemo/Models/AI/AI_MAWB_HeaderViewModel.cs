using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWB_HeaderViewModel : ViewModelBase
    {
        [RegularExpression("\\d{3}-\\d{8}", ErrorMessage ="MAWBNo should be 999-99999999")]
        [Required(ErrorMessage ="MAWBNO is mandatory")]
        public string MAWBNo { get; set; }
        public int? MAWBType { get; set; }
        public string MAWBTypeCode { get; set; }
        [Required]
        public int? IssuerID { get; set; }
        public string IssuerCode { get; set; }
        public int? IssueCityID { get; set; }
        public string IssueCityCode { get; set; }
        [Required]
        public DateTime? IssueDate { get; set; }
        public string MAWBLotNo { get; set; }
        public string issueType { get; set; }
        public string issueTypeCode { get; set; }
        public string updateInfo { get; set; }

        #region ReadOnly Operation

        public bool issuerRead { get; set; }
        public bool issuerTypeRead { get; set; }
        public bool mawbTypeRead { get; set; }
        public bool issueCityRead { get; set; }
        public bool mawbNoRead { get; set; }
      
        #endregion
    }
}
