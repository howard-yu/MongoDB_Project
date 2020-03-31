using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_HAWB_PickupViewModel : ViewModelBase
    {
        public int ID { get; set; }

        public int HAWBID { get; set; }

        [StringLength(255)]
     
        public string Address { get; set; }

        
        public int? Truck { get; set; }

        public DateTime? AvailPickup { get; set; }

        public DateTime? ActualPickup { get; set; }

        public string Remark { get; set; }
                
        public int PickupFrom { get; set; }


        public string PickupFromCode { get; set; }


        public string StationID { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }
        

        public string VehicleNo { get; set; }


        public string Driver { get; set; }


        public string Phone { get; set; }

        public bool? Show { get; set; }
                
        public int DELVTo { get; set; }


        public string DELVToCode { get; set; }


        public string DELVAddr { get; set; }

        public double? Weight { get; set; }

        [StringLength(10)]
        public string WeightUOM { get; set; }

        public DateTime? AvailPickupTo { get; set; }

        public DateTime? ActualPickupTo { get; set; }

        public int? PCS { get; set; }

        [StringLength(50)]
        public string PCSUOM { get; set; }

        public double? CWT { get; set; }

        [StringLength(10)]
        public string SendBy { get; set; }

        public DateTime? SendDate { get; set; }


        public string PickupOrder { get; set; }
        public string ActualPickupTime { get; set; }
        public string AvailPickupTime { get; set; }

        public string PickupFromName { get; set; }

        public string TruckName { get; set; }
        public string TruckerCode { get; set; }       

        public Dictionary<string, bool> docConfirm { get;set; }

        public Dictionary<string, string> docName { get; set; }
        public Dictionary<string, bool> docRequire { get; set; }

        //public List<AE_HAWB_DocRequiredViewModel> DocDetail { get; set; }

    }
}
