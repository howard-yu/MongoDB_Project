using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_HeaderViewModel : ViewModelBase
    {
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.MAWBNo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string MAWBNo { get; set; }
        public string MAWBLotNo { get; set; }
        public string MAWBNoURL { get; set; }
        // update by standard on 2019/11/27 Item 111
        public string AEURL { get; set; }
        public string AEBKNO { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.ServiceLevel), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string serviceLevel { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.HandlingCode), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string handlingcodeCategory { get; set; }
        public string handlingcodeItem { get; set; }
        public string appHAWBNo { get; set; }
        public string HAWBLog { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Milestone), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string milestone { get; set; }
        public string oneTimeOnly { get; set; }
        //Add by Bill @ 2018//08/29 VAL-1085 show shipment info
        public string ShptType { get; set; }
        public string CurrentMilestone { get; set; }
        public string NextMilestone { get; set; }
        public string HAWBNo { get; set; }
        //Add by Jane at 2019/10/16 Add TransShipmentMode, VAL-1740
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.TransShipmentMode), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string TransShipmentMode { get; set; }
    }
}
