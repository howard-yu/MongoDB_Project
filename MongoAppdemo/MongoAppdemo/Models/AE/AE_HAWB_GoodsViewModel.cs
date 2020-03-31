using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    /// <summary>
    /// Update by Royal @ 2018/8/1 Customs Regulation in Indonesia_HS Code and Tax Number, VAL-1020
    /// </summary>
    public class AE_HAWB_GoodsViewModel : ViewModelBase
    {
        public int? ActPCS { get; set; }

        public string ActPCSUOM { get; set; }
        public int? SLAC { get; set; }

        [StringLength(5)]
        public string SLACUOM { get; set; }

        [StringLength(5)]

        public string WTUOM { get; set; }

        public double? GWT { get; set; }

        public double? VWT { get; set; }

        public double? CWT { get; set; }

        public string Currency { get; set; }


        [StringLength(5)]
        public string RateClass { get; set; }

        public double? Rate { get; set; }

        public double? TotalAmount { get; set; }

        public bool? ShowRate { get; set; }


        public string ExportLIC { get; set; }


        public string Quantity { get; set; }

        [StringLength(20)]
        public string CommInv { get; set; }

        public string DESC { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public string Marks { get; set; }

        public int? BookedPCS { get; set; }

        [StringLength(5)]
        public string BookedWTUOM { get; set; }


        public double? BookedGWT { get; set; }


        public double? BookedVWT { get; set; }

        //add by Royal @ 2018/8/1 add HSCode
        [StringLength(200)]
        public string HSCode { get; set; }
    }
}
