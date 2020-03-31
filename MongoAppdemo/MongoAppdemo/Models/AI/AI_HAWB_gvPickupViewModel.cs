using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_gvPickupViewModel : ViewModelBase
    {
        public string PickupOrder { get; set; }
        public string Truck { get; set; }
        public string PickupFrom { get; set; }
        public DateTime ActualPickup { get; set; }
        public string Remark { get; set; }

    }
}
