using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_EntryListViewModel : ViewModelBase
    {
        public int? ID { get; set; }

        public string EntryType { get; set; }

        public string CustomsEntry { get; set; }

        public string FLTNo { get; set; }

        public DateTime? CustomsDate { get; set; }

        public int? TotalPCS { get; set; }

        public double? GWT { get; set; }

        public DateTime? LandingDate { get; set; }

        public int? CargoAt { get; set; }

        public int? Carrier { get; set; }

        public string Storage { get; set; }

        public int? EntryPort { get; set; }

        public int? MAWBID { get; set; }

        public string Damage { get; set; }

        public string Shortage { get; set; }

        public string Offload { get; set; }
    }
}
