using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    /// <summary>
    /// Add by Royal @ 2018/8/20 Add SMAWB Page ,VAL-861
    /// </summary>
    public class AE_SMAWBViewModel : ViewModelBase
    {
        public int ID { get; set; }
        public string MAWBNo { get; set; }
        public string Shipper { get; set; }
        public string CNEE { get; set; }
        public string PortOfDEPT { get; set; }
        public string PortOfDSTN { get; set; }
        public string ActPCS { get; set; }
        public string ActPCSUOM { get; set; }       
        public string GWT { get; set; }
        public string CWT { get; set; }
        public string WTUOM { get; set; }
        public string EMailPreAlert { get; set; }
        public string Status { get; set; }
        public string FinalImport { get; set; }
        public string Remark { get; set; }
        public string url { get; set; }
    }
}
