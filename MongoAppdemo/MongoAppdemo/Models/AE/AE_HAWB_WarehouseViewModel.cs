using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_HAWB_WarehouseViewModel : ViewModelBase
    {
        public int? WHActPCS { get; set; }

        [StringLength(5)]
        public string WHActPCSUOM { get; set; }

        public double? WHActWT { get; set; }

        [StringLength(5)]
        public string WHActWTUOM { get; set; }

        public double? WHActVWT { get; set; }

        [StringLength(5)]
        public string WHActVWTUOM { get; set; }

        [StringLength(20)]

        public string WHLocation { get; set; }

        public DateTime? WHArrivalDate { get; set; }

        public DateTime? WHPulloutDate { get; set; }

        [StringLength(50)]

        public string WHContainer { get; set; }

        [StringLength(255)]

        public string WHRemark { get; set; }

        [StringLength(50)]

        public string WHCargoStatus { get; set; }

        [StringLength(20)]
        public string WHReceiptNo { get; set; }
    }
}
