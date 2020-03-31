using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AMS_SplitShipmentPara : ViewModelBase
    {
        public int? MAWBID { get; set; }
        public int? CarrierBookID { get; set; }
        public string Mode { get; set; }
        public List<AMS_SplitShipmentViewModel> SplitShipments { get; set; }
    }
    public class AMS_SplitShipmentViewModel:ViewModelBase
    {
        public int? ID { get; set; }
        public string StationID { get; set; }
        public int? CarrierBookID { get; set; }
        public string HAWBNo { get; set; }
        public int? TotalPCS { get; set; }
        public int? ShippedPCS { get; set; }
        [UIHint("GridIntegerTemplate")]
        public int? OnBoardPCS { get; set; }
        public double? TotalWT { get; set; }
        public double? ShippedWT { get; set; }
        [UIHint("GridWeightTextBoxTemplate")]
        public double? OnBoardWT { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public int? ActPCS { get; set; }
        public double? ActWT { get; set; }
    }
}
