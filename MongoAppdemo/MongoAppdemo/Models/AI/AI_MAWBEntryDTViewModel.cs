using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWBEntryDTViewModel : ViewModelBase
    {
        public int ID { get; set; }

        public int? HAWBID { get; set; }

        public int? EntryID { get; set; }

        public int? EntryPCS { get; set; }

        public double? EntryWT { get; set; }

        [StringLength(10)]
        public string StationID { get; set; }

        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? Damage { get; set; }

        public int? Shortage { get; set; }

        public int? Offload { get; set; }

        public int? Supplus { get; set; }
       
        [MaxLength(8)]
        [Timestamp]
        public byte[] Version { get; set; }

        public double? DamageWT { get; set; }

        public double? ShortageWT { get; set; }

        public double? SupplusWT { get; set; }

        public string Remark { get; set; }
    }
}
