using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_MAWB_AppHAWBViewModel : ViewModelBase
    {
        public int? ID { get; set; }

        public string MAWBNo { get; set; }

        public string status { get; set; }

        public string createdBy { get; set; }

        public DateTime? createdDate { get; set; }

        public string udpatedBy { get; set; }

        public DateTime? updatedDate { get; set; }
    }
}
