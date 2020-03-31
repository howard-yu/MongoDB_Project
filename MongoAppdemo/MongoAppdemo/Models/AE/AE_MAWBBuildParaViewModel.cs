using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    //Search MAWBBuild Source Search 
    public class AE_MAWBBuildParaViewModel : SearchParaBase
    {
        
        public int? MAWBID { get; set; }
        public int? PortofDSTN { get; set; }

        public string DateType { get; set; }
        public DateTime? DateValue { get; set; }

        public bool isColoadOut { get; set; }


        public string HAWBNo { get; set; }
        public string Customer { get; set; }
        public string Shipper { get; set; }
        public string CNEE { get; set; }
    }
}

