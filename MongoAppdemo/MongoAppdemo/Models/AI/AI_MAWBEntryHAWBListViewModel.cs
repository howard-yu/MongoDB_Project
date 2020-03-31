using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWBEntryHAWBListViewModel : ViewModelBase
    {
        public int ID { get; set; }

        public string HAWBNo { get; set; }

        public string PortOfDEPT { get; set; }

        public string PortOfDSTN { get; set; }

        public string Shipper { get; set; }

        public string CNEE { get; set; }              

        public int? ActPCS { get; set; }

        public int? EntryPCS { get; set; }

        public int? ShippedPCS { get; set; }

        public string ActPCSUOM { get; set; }

        public double? CWT { get; set; }

        public double? GWT { get; set; }

        public double? EntryGWT { get; set; }

        public double? EntryWT { get; set; }

        public double? ShippedWT { get; set; }

        public string WTUOM { get; set; }

        public string AWBType { get; set; }

        public string Status { get; set; }

        [StringLength(10)]
        public string StationID { get; set; }

        public string FinalImport { get; set; }

        public int? Damage { get; set; }

        public int? Offload { get; set; }

        public int? Shortage { get; set; }

        public int? Supplus { get; set; }

        public double? DamageWT { get; set; }

        public double? ShortageWT { get; set; }

        public double? SupplusWT { get; set; }

        public string Remark { get; set; }
    }
}
