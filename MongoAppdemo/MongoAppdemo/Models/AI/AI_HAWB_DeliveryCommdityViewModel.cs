using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_DeliveryCommdityViewModel : ViewModelBase
    {
        public int ID { get; set; }
        public string StationID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Packages), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public double? Packages { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.PackagesUOM), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string PackagesUOM { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Weight), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public double? Weight { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.WeightUOM), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string WeightUOM { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Volume), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public double? Volume { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.VolumeUOM), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string VolumeUOM { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Length), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public double? Length { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Width), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public double? Width { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Height), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public double? Height { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.UNDG), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string UNDG { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.DeliveryID), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public int? DeliveryID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.ContainerID), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public int? ContainerID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.CreatedBy), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string CreatedBy { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.CreatedDate), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.UpdatedBy), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string UpdatedBy { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.UpdatedDate), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? UpdatedDate { get; set; }
    }
}
