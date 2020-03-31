using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWBEntryHAWBViewModel : ViewModelBase
    {
        public int ID { get; set; }

        public int? HAWBID { get; set; }

        public string HAWBNo { get; set; }

        public string PortOfDEPT { get; set; }

        public string PortOfDSTN { get; set; }

        public string Shipper { get; set; }

        public string CNEE { get; set; }              

        public int? ActPCS { get; set; }

        public int? ShippedPCS { get; set; }

        public string ActPCSUOM { get; set; }

        public float? CWT { get; set; }

        public float? GWT { get; set; }

        public float? ShippedWT { get; set; }

        public string WTUOM { get; set; }

        public string AWBType { get; set; }

        public string Status { get; set; }

        [StringLength(10)]
        public string StationID { get; set; }

        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? EntryID { get; set; }

        public int? EntryPCS { get; set; }

        public float? EntryWT { get; set; }

        [MaxLength(8)]
        [Timestamp]
        public byte[] Version { get; set; }

        public int? Damage { get; set; }

        public int? Offload { get; set; }

        public int? Shortage { get; set; }

        public int? Supplus { get; set; }

        public float? DamageWT { get; set; }

        public float? ShortageWT { get; set; }

        public float? SupplusWT { get; set; }

        public string Remark { get; set; }
    }
}
