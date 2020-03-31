using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_MAWB_eManifestDetailViewModel : ViewModelBase
    {
        public string LocalServer { get; set; }
        public string CustType { get; set; }

        public int? CustomerID { get; set; }
        [Editable(false)]
        public string CustName { get; set; }
        [Editable(false)]
        public string CustAdd { get; set; }
        [Editable(false)]
        public string CountryName { get; set; }
        [Required]
        public string Zip { get; set; }
    }
}
