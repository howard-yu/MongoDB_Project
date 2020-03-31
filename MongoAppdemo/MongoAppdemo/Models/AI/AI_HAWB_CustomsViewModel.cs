using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_CustomsViewModel : ViewModelBase
    {
        public int? CustomsDeclareParty { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.DeclareParty), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string CustomsDeclarePartyCode { get; set; }

        public int? CustomsHandledBy { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.HandledBy), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string CustomsHandledByCode { get; set; }

        [StringLength(10)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.DocType), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string CustomsDocType { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.AvailableDateTime), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public DateTime? CustomsAvaDate { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.DeclaredDateTime), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public DateTime? CustomsDecDate { get; set; }

        [StringLength(255)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Remark), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string CustomsRemark { get; set; }

        [StringLength(50)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CustomsStatus), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string CustomsStatus { get; set; }

    }
}
