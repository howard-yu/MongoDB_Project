
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_PickupDeliveryViewModel : ViewModelBase
    {

        public int ID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Address), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string Address { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Truck), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public int? Truck { get; set; }
        public string TruckCode { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.ActualDelivery), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? ActualDelivery { get; set; }

        [StringLength(255)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Remark), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string Remark { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.DeliveryTo), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public int? DeliveryTo { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.AvailDelivery), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? AvailDelivery { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.BrokerageID), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public int? BrokerageID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.StationID), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string StationID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.CreatedBy), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string CreatedBy { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.CreatedDate), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime CreatedDate { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.UpdatedBy), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string UpdatedBy { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.UpdatedDate), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime UpdatedDate { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.ArrivalDT), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? ArrivalDT { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.PickupFrom), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public int? PickupFrom { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.AvailDeliveryTo), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? AvailDeliveryTo { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.AvailPickup), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? AvailPickup { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.ActualPickup), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? AvailPickupTo { get; set; }
        public DateTime? ActualPickup { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.PickupAddress), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string PickupAddress { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.OrderNo), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string OrderNo { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Mark), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string Mark { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Commodity), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string Commodity { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.PickupFrom), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string PickupFromCode { get; set; }
        public string PickupFromName { get; set; }
        public string PickupFromNameText { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.DeliveryTo), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string DeliveryToCode { get; set; }
        public string DeliveryToName { get; set; }
        public string DeliveryToNameText { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Truck), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string TruckName { get; set; }
        public string TruckNameText { get; set; }

        public String printUrl { get; set; }

        public string LotStatus { get; set; }
    }
}
