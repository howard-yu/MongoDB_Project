using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWB_InstructionViewModel : ViewModelBase
    {
        public int? ID { get; set; }

        public int? MAWBID { get; set; }
     
        public string From { get; set; }

        [StringLength(20)]
        [UIHint("InstructionToList")]
        public string Category { get; set; }

        [StringLength(255)]
        [UIHint("InstructionSubjectTemplate")]
        public string Subject { get; set; }

        [Editable(false)]
        public DateTime Date { get; set; }
        
        [StringLength(10)]
        public string StationID { get; set; }
       
        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }
        
        [StringLength(6)]
        public string UpdatedBy { get; set; }

        [Editable(false)]
        public string UpdatedByName { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Editable(false)]
        public string DateNew
        {
            get
            {
                return Date.ToString("yyyy/MM/dd hh:mm:ss");
            }
        }

        [MaxLength(8)]
        [Timestamp]
        public byte[] Version { get; set; }

    }
}
