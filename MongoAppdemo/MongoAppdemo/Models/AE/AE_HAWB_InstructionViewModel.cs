using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_HAWB_InstructionViewModel : ViewModelBase
    {
        public int ID { get; set; }

        public int HAWBID { get; set; }

        [Editable(false)]
        [StringLength(10)]
        public string From { get; set; }

        [StringLength(20)]
        [UIHint("InstructionToList")]
        [Required(ErrorMessage = "Category is mandatory")]
        public string Category { get; set; }

        [StringLength(255)]
        //update by Rou 2018/8/14 -- Change the textbox to a textarea , VAL-965
        [UIHint("InstructionSubjectTemplate")]
        [Required(ErrorMessage = "Subject is mandatory")]
        public string Subject { get; set; }

        [Editable(false)]
        public DateTime Date { get; set; }

        
        [StringLength(10)]
        public string StationID { get; set; }

       
        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        
        [StringLength(6)]
        public string UpdatedBy { get; set; }

        [Editable(false)]
        public string UpdatedByName { get; set; }

        public DateTime UpdatedDate { get; set; }
        [Editable(false)]
        public string DateNew
        {
            get
            {
                return UpdatedDate.ToString("yyyy/MM/dd hh:mm:ss");
            }
        }

    }
}
