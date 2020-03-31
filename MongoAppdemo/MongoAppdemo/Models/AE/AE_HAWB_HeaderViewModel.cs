using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    //Add by Bill @ 2018//08/29 VAL-1085 show shipment info
    //Add by Harry @ 2010/01/14 VP2-920 ,Air/Air Shipment Handle Requirement
    public class AE_HAWB_HeaderViewModel : ViewModelBase
    {
        
        public string MAWBNo { get; set; }
        public string MAWBLotNo { get; set; }
        public string MAWBNoURL { get; set; }
        public string serviceLevel { get; set; }
        public string handlingcodeCategory { get; set; }
        public string handlingcodeItem { get; set; }
        public string appHAWBNo { get; set; }
        public string HAWBLog { get; set; }
        public string milestone { get; set; }
        public string oneTimeOnly { get; set; }
        //Add by Bill @ 2018//08/29 VAL-1085 show shipment info
        public string ShptType { get; set; }
        public string CurrentMilestone { get; set; }
        public string NextMilestone { get; set; }

        //Add by Harry @ 2019/01/14 Add TransShipmentMode
        public string TransShipmentMode { get; set; }

        //Add by Howard @ 2020/01/08 VAL-3541
        public bool handlingcodeRead { get; set; }
    }
}
