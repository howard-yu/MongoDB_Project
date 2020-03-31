using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    //Update by Ziv at 2018/8/23 VAL-1072 Add 3 column(InvNos, InvCnt, PrtInvCnt)
    public class AE_HAWB_SearchViewModel : SearchResultBase
    {
        ////[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.HAWBID), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public int HAWBID { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.MAWBNo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string MAWBNo { get; set; }

        ////[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.HAWBID), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public int? MAWBID { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.AWBType), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string AWBType { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.HAWBNo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string HAWBNo { get; set; }

        ////[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.MTSNo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string MTSNo { get; set; }

        ////[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.StationID), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string StationID { get; set; }

        ////[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PreAlertUser), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string PreAlertUser { get; set; }

        ////[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PreAlertDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public DateTime? PreAlertDate { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.SHPR), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string SHPR { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CNEE), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string CNEE { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CUST), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string CUST { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.ThirdPT), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string ThirdPT { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PortOfDSTN), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string PortOfDSTN { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PofDEPT), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string PortOfDEPT { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PlaceofRECP), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string PlaceofRECP { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PlaceofDELV), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string PlaceofDELV { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PCS), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string PCSUnit { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.GWT), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string GWTUOM { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CWT), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string CWTUOM { get; set; }

        //public int? PCS { get; set; }
        //public string PUnit { get; set; }
        //public double? GWT { get; set; }
        //public double? CWT { get; set; }
        //public string WTUOM { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.INST), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string INST { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Bill), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string Bill { get; set; }

        ////[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PreAlertTime), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string PreAlertTime { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.LotNo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string LotNo { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Status), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string Status { get; set; }

        ////[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.StatusID), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public int StatusID { get; set; }

        ////[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CreatedDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public DateTime CreatedDate { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.GP), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public decimal? GP { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.StationCode), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string StationCode { get; set; }

        ////[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.ParentAWBType), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        //public string ParentAWBType { get; set; }




        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PreInfo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string PreInfo { get; set; }

        //[Display(Name = nameof(ValuePlus.Resource.Lang.AMS.HAWBID), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string HAWBLinkUrl { get; set; }

        public int? CustomerID { get; set; }

        ///<summary>
        ///HAWBID
        ///</summary>
        public int HAWBID { get; set; }

        ///<summary>
        ///MAWBNo
        ///</summary>
        public string MAWBNo { get; set; }

        ///<summary>
        ///MAWBID
        ///</summary>
        public int? MAWBID { get; set; }

        ///<summary>
        ///AWBType
        ///</summary>
        public string AWBType { get; set; }

        ///<summary>
        ///HAWBNo
        ///</summary>
        public string HAWBNo { get; set; }

        ///<summary>
        ///MTSNo
        ///</summary>
        public string MTSNo { get; set; }

        ///<summary>
        ///StationID
        ///</summary>
        public string StationID { get; set; }

        ///<summary>
        ///PreAlertUser
        ///</summary>
        public string PreAlertUser { get; set; }

        ///<summary>
        ///PreAlertDate
        ///</summary>

        public DateTime? PreAlertDate { get; set; }

        ///<summary>
        ///SHPR
        ///</summary>

        public string SHPR { get; set; }

        ///<summary>
        ///CNEE
        ///</summary>

        public string CNEE { get; set; }

        ///<summary>
        ///CUST
        ///</summary>

        public string CUST { get; set; }

        ///<summary>
        ///ThirdPT
        ///</summary>
        public string ThirdPT { get; set; }

        ///<summary>
        ///PortOfDSTN
        ///</summary>
        public string PortOfDSTN { get; set; }

        ///<summary>
        ///PortOfDEPT
        ///</summary>
        public string PortOfDEPT { get; set; }

        ///<summary>
        ///PlaceofRECP
        ///</summary>
        public string PlaceofRECP { get; set; }

        ///<summary>
        ///PlaceofDELV
        ///</summary>
        public string PlaceofDELV { get; set; }

        ///<summary>
        ///PCS
        ///</summary>
        public int? PCS { get; set; }

        ///<summary>
        ///PCSUnit
        ///</summary>
        public string PCSUnit { get; set; }

        ///<summary>
        ///PUnit
        ///</summary>

        public string PUnit { get; set; }

        ///<summary>
        ///GWT
        ///</summary>
        public double? GWT { get; set; }

        ///<summary>
        ///CWT
        ///</summary>
        public double? CWT { get; set; }

        ///<summary>
        ///WTUOM
        ///</summary>

        public string WTUOM { get; set; }

        ///<summary>
        ///GWTUOM
        ///</summary>
        public string GWTUOM { get; set; }

        ///<summary>
        ///CWTUOM
        ///</summary>
        public string CWTUOM { get; set; }

        ///<summary>
        ///INST
        ///</summary>

        public string INST { get; set; }

        ///<summary>
        ///Bill
        ///</summary>

        public string Bill { get; set; }

        ///<summary>
        ///PreAlertTime
        ///</summary>
        public string PreAlertTime { get; set; }

        ///<summary>
        ///LotNo
        ///</summary>
        public string LotNo { get; set; }

        ///<summary>
        ///Status
        ///</summary>

        public string Status { get; set; }

        ///<summary>
        ///StatusID
        ///</summary>

        public int StatusID { get; set; }

        ///<summary>
        ///CreatedDate
        ///</summary>

        public DateTime CreatedDate { get; set; }

        ///<summary>
        ///GP
        ///</summary>
        public decimal? GP { get; set; }

        ///<summary>
        ///StationCode
        ///</summary>

        public string StationCode { get; set; }

        ///<summary>
        ///ParentAWBType
        ///</summary>

        public string ParentAWBType { get; set; }
        
        public string CreatedBy { get; set; }

        /// <summary>
        /// Create By Bill He @ 2018/06/01 add PO search page ,show PO number
        /// </summary>
        public string PONo { get; set; }

        ///<summary>
        ///Created by Amanda Lee @ 2018/08/02 add DN to search page and show DN number
        ///</summary>
        public string DNNo { get; set; }

        ///<summary>
        ///Available Date
        ///Create by Harry @ 2018/08/10 Add Available Date to search page.
        ///</summary>

        public DateTime? AvaiDate { get; set; }

        ///<summary>
        ///ETD
        ///Create by Harry @ 2018/08/10 Add ETD to search page.
        ///</summary>

        public DateTime? ETD { get; set; }

        ///<summary>
        ///ETA
        ///Create by Harry @ 2018/08/10 Add ETA to search page.
        ///</summary>

        public DateTime? ETA { get; set; }

        ///<summary>
        ///GPP
        ///Create by Harry @ 2018/08/10 Add GPP to search page.
        ///</summary>
        public decimal? GPP { get; set; }

        ///<summary>
        ///ServiceLevel
        ///Create by Harry @ 2018/08/10 Add ServiceLevel to search page.
        ///</summary>
        public string ServiceLevel { get; set; }

        ///<summary>
        ///handlingCode
        ///Create by Harry @ 2018/08/10 Add handlingCode to search page.
        ///</summary>
        public string handlingCode { get; set; }

        ///<summary>
        ///handlingItem
        ///Create by Harry @ 2018/08/10 Add handlingItem to search page.
        ///</summary>
        public string handlingItem { get; set; }

        ///<summary>
        ///UpdatedBy
        ///Create by Harry @ 2018/08/10 Add UpdatedBy to search page.
        ///</summary>
        public string UpdatedBy { get; set; }

        ///<summary>
        ///UpdatedDate
        ///Create by Harry @ 2018/08/10 Add UpdatedDate to search page.
        ///</summary>
        public DateTime? UpdatedDate { get; set; }
        
        //Add by Ziv at 2018/8/23
        public string InvNos { get; set; }
        public int InvCnt { get; set; }
        public int PrtInvCnt { get; set; }

        ///<summary>
        ///TradeTerm
        ///Create by Rou @2018/11/5 Add TradeTerm to AEHAWBSearch
        ///</summary>
        public string TradeTerm { get; set; }

        ///<summary>
        ///TradeTerm
        ///Create by Wilson.H @ 2019/10/17 VP2-1040 Add parentAWB to AEHAWBSearch        
        ///</summary>
        public int? parentAWB { get; set; }
    }
}
