using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_MAWB_OnBoardDetailViewModel : ViewModelBase
    {
        public int? ID { get; set; }

        public int? MAWBID { get; set; }

        ////Update by Amanda @ 2019/10/15 rename status to onboard status to avoid conflict VAL-3424
        [UIHint("OnBoardStatusToList")]
        public string OnboardStatus { get; set; }

        [UIHint("InstructionSubjectTemplate")]
        public string Remark { get; set; }

        [Editable(false)]
        public string CreateBy { get; set; }

        [Editable(false)]
        public DateTime? CreatedDate { get; set; }

        [Editable(false)]
        public string UpdateBy { get; set; }

        [Editable(false)]
        public DateTime? UpdateDate { get; set; }
    }
}
