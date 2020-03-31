using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//update by Amy @ 2018/7/17 VAL-981 Show eManifest party
namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_MAWB_eManifestViewModel : ViewModelBase
    {
        public int ID { get; set; }
        public string PDEPT { get; set; }
        public string PDSTN { get; set; }
        public string LasteManifestTime { get; set; }
        public string LasteManifestBy { get; set; }
        public string LastAMSTime { get; set; }
        public string LastAMSBy { get; set; }
        public bool IseManifest { get; set; }
        public bool IsAMS { get; set; }
        public bool GVVisiable { get; set; }
        public bool BtnYesVisiable { get; set; }
        public string BtnYesText { get; set; }
        public bool ManifestEnable { get; set; }
        public bool IsDAWB { get; set; }
        public string eManifestParty { get; set; } //update by Amy @ 2018/7/17
        public IList<AE_MAWB_eManifestDetailViewModel> eMainifestDetail { get; set; }
    }
}
