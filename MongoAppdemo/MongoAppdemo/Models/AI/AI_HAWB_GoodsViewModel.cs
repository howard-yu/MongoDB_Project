using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_GoodsViewModel : ViewModelBase
    {
  
        public int? ActPCS { get; set; }

        [StringLength(10)]
        public string ActPCSUOM { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.SLAC), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? SLAC { get; set; }

        [StringLength(5)]
        public string SLACUOM { get; set; }

        [StringLength(5)]
        public string WTUOM { get; set; }

        public double? GWT { get; set; }

        public double? VWT { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CWT), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public double? CWT { get; set; }

        [StringLength(5)]
        public string Currency { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.RateClass), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        [StringLength(5)]
        public string RateClass { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Rate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public double? Rate { get; set; }
        public double? TotalAmount { get; set; }

        public bool? ShowRate { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.ExportLIC), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        [StringLength(255)]
        public string ExportLIC { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Quantity), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        [StringLength(20)]
        public string Quantity { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CommInv), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        [StringLength(20)]
        public string CommInv { get; set; }

        [StringLength(750)]
        public string DESC { get; set; }
  
        public string Marks { get; set; }

        public string Remark { get; set; }

        public int? BookedPCS { get; set; }

        [StringLength(5)]
        public string BookedWTUOM { get; set; }

        public double? BookedGWT { get; set; }

        public double? BookedVWT { get; set; }

        [StringLength(200)]
        public string HSCode { get; set; }
    }
}
