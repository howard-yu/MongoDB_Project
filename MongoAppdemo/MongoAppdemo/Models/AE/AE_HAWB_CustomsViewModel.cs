using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_HAWB_CustomsViewModel : ViewModelBase
    {
        
        public int? CustomsDeclareParty { get; set; }

       
        public string CustomsDeclarePartyCode { get; set; }
        
        public int? CustomsHandledBy { get; set; }

        public string CustomsHandledByCode { get; set; }

        public string CustomsDocType { get; set; }

        public DateTime? CustomsAvaDate { get; set; }


        public DateTime? CustomsDecDate { get; set; }

        public string CustomsRemark { get; set; }

        public string CustomsStatus { get; set; }

    }
}
