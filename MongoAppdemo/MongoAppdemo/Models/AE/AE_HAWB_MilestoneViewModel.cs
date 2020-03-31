using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_HAWB_MilestoneViewModel : ViewModelBase
    {
        ////ms.Key = HNo;
        ////    ms.OwnerStationID = ownerStationID;
        ////    ms.MilestoneTime = confirmDate;
        ////    ms.CreatedBy = ConfirmBy;
        ////    ms.ProductLine = ps;
        ////    if (ps == ReSM.Productline.eAMS)
        ////        ms.MilestoneID = 500;
        ////    else
        ////        ms.MilestoneID = 100400;

        public string Key { get; set; }

        public string CreatedBy { get; set; }

        public string OwnerStationID { get; set; }

        public DateTime MilestoneTime { get; set; }


        public int MilestoneID { get; set; }
    }
}
