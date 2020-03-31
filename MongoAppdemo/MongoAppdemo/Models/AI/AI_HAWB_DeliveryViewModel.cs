using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_DeliveryViewModel : ViewModelBase
    {
        public int ID { get; set; }

        public int HAWBID { get; set; }

        [Editable(false)]
        [StringLength(10)]
        public string From { get; set; }

        [StringLength(20)]
        [UIHint("InstructionToList")]
        public string Category { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }

        [Editable(false)]
        public DateTime Date { get; set; }


        [StringLength(10)]
        public string StationID { get; set; }


        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }


        [StringLength(6)]
        public string UpdatedBy { get; set; }

        [Editable(false)]
        public string UpdatedByName { get; set; }

        public DateTime UpdatedDate { get; set; }

        public String Consol { get; set; }
        public String Delivery { get; set; }
        public String Order { get; set; }
        public String TruckCompany { get; set; }
        public String PickupFrom { get; set; }
        public DateTime Pickup { get; set; }
        public String Remark { get; set; }
        public String Docrequired { get; set; }
        public String Received { get; set; }
        public String Require { get; set; }
        public String Document { get; set; }
        public bool Show { get; set; }
        public String VehicleNo { get; set; }
        public String Driver { get; set; }
        public String PHONE { get; set; }
        public String Involved { get; set; }
        public String CNEE { get; set; }
        public String Broker { get; set; }
        public String SAVEAS { get; set; }
        public int? PCS { get; set; }
        public string PCSUOM {get; set;}
        public int? CWT { get; set; }
        public int? Weight { get; set; }
        public string GWTUOM { get; set; }
        public string TruckerCode { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Address), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public string Address { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.Truck), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public int? Truck { get; set; }
        public string TruckCode { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.ActualDelivery), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? ActualDelivery { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.DeliveryTo), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public int? DeliveryTo { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.AvailDelivery), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? AvailDelivery { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.BrokerageID), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public int? BrokerageID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.ArrivalDT), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? ArrivalDT { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.AvailDeliveryTo), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? AvailDeliveryTo { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.AvailPickup), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? AvailPickup { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.CBS.AvailPickup), ResourceType = typeof(ValuePlus.Resource.Lang.CBS))]
        public DateTime? AvailPickupTO { get; set; }

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


        [Editable(false)]
        public string DateNew
        {
            get
            {
                return Date.ToString("yyyy/MM/dd hh:mm:ss");
            }
        }
    }
}
