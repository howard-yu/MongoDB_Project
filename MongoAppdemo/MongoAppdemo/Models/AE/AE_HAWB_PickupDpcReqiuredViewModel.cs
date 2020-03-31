using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_HAWB_DocRequiredViewModel : ViewModelBase
    {
        public int ID { get; set; }

        public int? PickupID { get; set; }

        public int? DocID { get; set; }

        [StringLength(255)]
        public string DocName { get; set; }

        public bool Confirmed { get; set; }

        [Required]
        [StringLength(10)]
        public string StationID { get; set; }

        [Required]
        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Required]
        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        
        [MaxLength(8)]
        [Timestamp]
        public byte[] Version { get; set; }

    }
}
