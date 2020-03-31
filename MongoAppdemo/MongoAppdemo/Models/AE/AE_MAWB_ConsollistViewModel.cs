﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    /// <summary>
    /// Update by Royal @ 2018/7/2, fix not filter&Sorting in search grid,VP2-771
    /// Update by Ziv at 2018/8/23 VAL-1072 Add 3 column(InvCnt, PrtInvCnt)
    /// </summary>
    public class AE_MAWB_ConsollistViewModel : SearchResultBase
    {
        public int ID { get; set; }
        public string HAWBNo { get; set; }
        public string ServiceLevel { get; set; }
        public string Customer { get; set; }
        public string Shipper { get; set; }
        public string CNEE { get; set; }
        public string PlaceOfRCPT { get; set; }
        public string PortOfDSTN { get; set; }
        public string PlaceOfDELV { get; set; }
        public string PortOfDEPT { get; set; }
        public string PreAlertUser { get; set; }
        public DateTime? PreAlertDate { get; set; }
        public string ActPCSUOM { get; set; }
        public string ActPCS { get; set; }
        public string CWT { get; set; }
        public string VWT { get; set; }
        public string GWT { get; set; }
        public string WTUOM { get; set; }
        public string AWBType { get; set; }
        public int SH { get; set; }
        public string Status { get; set; }
        public string StationID { get; set; }
        public string FinalImport { get; set; }
        public string Remark { get; set; }
        public string NatureOfGoods { get; set; }
        public string SalesCostUrl { get; set; }
        public string HAWBNoUrl { get; set; }


        public int ThirdParty { get; set; }
        public string ShptType { get; set; }
        public double CUFT        { get; set; }

        //Update by Royal @ 2018/7/2
        //public int Count { get; set; }
        public int MAWBID { get; set; }

        private bool _CanTick = true;
        public bool CanTick { get { return _CanTick; } set { _CanTick = value; } }

        //Update by Royal @ 2018/7/30
        public string Bill { get; set; }
        //Add by Ziv at 2018/8/23
        public int InvCnt { get; set; }
        public int PrtInvCnt { get; set; }
    }
}