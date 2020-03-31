using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_APPHAWBNo_Para : SearchParaBase
    {
        public string CustomerCode { get; set; }

        public int? CustomerID { get; set; }

        public int? AppointedValue { get; set; }

        public int? ReservedValue { get; set; }

    }
    public class AE_App_GWT_ViewModel
    {
        public string HAWBNo { get; set; }

        public double? GWT { get; set; }

        public double? WHActWT { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
