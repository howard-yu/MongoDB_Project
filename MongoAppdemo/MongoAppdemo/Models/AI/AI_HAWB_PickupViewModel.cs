using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_PickupViewModel : ViewModelBase
    {
        public int ID { get; set; }

        public int HAWBID { get; set; }
        public string CNEE { get; set; }
        public String Formsurl { get; set; }
        [StringLength(255)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Address), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string Address { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Involved), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string InvolvedBy { get; set; }

        public int? Truck { get; set; }

        public DateTime? AvailPickup { get; set; }

        public DateTime? ActualPickup { get; set; }

        [StringLength(255)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Remark), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string Remark { get; set; }

        public int PickupFrom { get; set; }

        public string Consol { get; set; }
        public string Delivery { get; set; }
        public string Order { get; set; }
        public string TruckCompany { get; set; }
        public string Pickup { get; set; }
        public string TruckerCode { get; set; }


        [Range(1, 99999999, ErrorMessage = "Pickup is mandatory")]
        [Required(ErrorMessage = "Pickup is mandatory")]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PickupFrom), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string PickupFromCode { get; set; }

        [Required]
        [StringLength(10)]
        public string StationID { get; set; }

        [Required]
        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [StringLength(50)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.VehicleNo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string VehicleNo { get; set; }

        [StringLength(50)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Driver), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string Driver { get; set; }

        [StringLength(50)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Phone), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string Phone { get; set; }

        public bool? Show { get; set; }

        public int DELVTo { get; set; }

        [Range(1, 99999999, ErrorMessage = "Delivery To is mandatory")]
        [Required(ErrorMessage = "Delivery To is mandatory")]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.DELVTo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string DELVToCode { get; set; }

        [StringLength(255)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Address), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string DELVAddr { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Weight), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public double? Weight { get; set; }

        [StringLength(10)]
        public string WeightUOM { get; set; }

        public DateTime? AvailPickupTo { get; set; }

        public DateTime? ActualPickupTo { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PCS), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? PCS { get; set; }

        [StringLength(50)]
        public string PCSUOM { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CWT), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public double? CWT { get; set; }

        [StringLength(10)]
        public string SendBy { get; set; }

        public DateTime? SendDate { get; set; }
        public bool? IsPickup { get; set; }

        ///<summary>
        ///ConsolePickupID
        ///</summary>
        public int? ConsolePickupID { get; set; }

        ///<summary>
        ///ConsoleCount
        ///</summary>
        public int? ConsoleCount { get; set; }

        ///<summary>
        ///Save as Default
        ///</summary>
        public Dictionary<string, bool> SaveAsDefault { get; set; }

        public string PickupOrder { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.ActualPickupTime), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string ActualPickupTime { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.AvailPickupTime), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string AvailPickupTime { get; set; }

        public string PickupFromName { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.TruckName), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string TruckName { get; set; }

        public Dictionary<string, bool> docConfirm { get; set; }
        public Dictionary<string, bool> docIsPickup { get; set; }
        

        public Dictionary<string, string> docName { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.docRequire), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public Dictionary<string, bool> docRequire { get; set; }

        //public List<AI_HAWB_DocRequiredViewModel> DocDetail { get; set; }

        public string url_ConsolDetail
        {
            get; set;
        }

    }
}
