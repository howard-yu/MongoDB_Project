using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_ExtraViewModel : ViewModelBase
    {
        [StringLength(50)]
        public string Extra0 { get; set; }

        [StringLength(50)]
        public string Extra1 { get; set; }

        [StringLength(50)]
        public string Extra2 { get; set; }

        [StringLength(50)]
        public string Extra3 { get; set; }

        [StringLength(50)]
        public string Extra4 { get; set; }

        [StringLength(50)]
        public string Extra5 { get; set; }

        [StringLength(50)]
        public string Extra6 { get; set; }

        [StringLength(50)]
        public string Extra7 { get; set; }

        [StringLength(50)]
        public string Extra8 { get; set; }

        [StringLength(50)]
        public string Extra9 { get; set; }

        [StringLength(50)]
        public string OEM { get; set; }

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

        [StringLength(10)]
        public string PLT { get; set; }

        [StringLength(10)]
        public string DESTWHSE{ get; set; }

        [StringLength(10)]
        public string PLT2 { get; set; }

        [StringLength(10)]
        public string CTNS { get; set; }

        public DateTime? AGREEDLEADTIME { get; set; }

    }
}

