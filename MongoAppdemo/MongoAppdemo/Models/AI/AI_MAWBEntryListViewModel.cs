using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWB_EntryListViewModel:ViewModelBase
    {
        public int? ID { get; set; }

        public string EntryType { get; set; }

        public string CustomsEntry { get; set; }

        public string FLTNo { get; set; }

        public DateTime? CustomsDate { get; set; }

        public int? TotalPCS { get; set; }

        public double? GWT { get; set; }

        public DateTime? LandingDate { get; set; }

        public int? CargoAt { get; set; }

        public int? Carrier { get; set; }

        public string Storage { get; set; }

        public int? EntryPort { get; set; }

        public int? MAWBID { get; set; }

        public string Damage { get; set; }

        public string Shortage { get; set; }

        public string Offload { get; set; }




        public DateTime CreatedDate { get; set; }

        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }


        [Required]
        public int? EntryPortId { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.EntryPortCode), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string EntryPortCode { get; set; }

        [Required]
        public int? CargoAtId { get; set; }

        public string CargoAtCode { get; set; }


        public string GWTUOM { get; set; }

        public DateTime? StorageDate { get; set; }

        [Required]
        public int? CarrierId { get; set; }

        public string CarrierCode { get; set; }

        [MaxLength(8)]
        [Timestamp]
        public byte[] Version { get; set; }

        public int? CarriersId { get; set; }

        public string CarriersCode { get; set; }

        public int AvailId { get; set; }

        public string AvailCode { get; set; }

        public string AvailAddr { get; set; }

        public DateTime? AvailDate { get; set; }
    }
}
