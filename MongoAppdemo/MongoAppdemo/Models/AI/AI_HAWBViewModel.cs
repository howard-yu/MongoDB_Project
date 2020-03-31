using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWBViewModel : ViewModelBase
    {
        public string DeliverConsleVersion = System.Configuration.ConfigurationManager.AppSettings["DeliverConsleVersion"];

        public int ID { get; set; }

        public int HAWBID { get; set; }

        public int? MAWBID { get; set; }
        [Required]
        public int? customerID { get; set; }
        
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.HAWBNo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        [Required]
        public string HAWBNo { get; set; }

        [StringLength(10)]
        public string StationID { get; set; }

        public int? ParentAWB { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Customer), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? Customer { get; set; }

        public int? BBAgent { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CNEE), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string CNEECODE { get; set; }

        [StringLength(5)]
        public string AWBType { get; set; }


        public DateTime? IssueDate { get; set; }

        [StringLength(10)]
        public string PrintPerson { get; set; }

        public double? DueToAgent { get; set; }

        public double? DueToCarrier { get; set; }

        public double? CUFT { get; set; }

        public bool? CYM { get; set; }

        public bool? NoExpect { get; set; }

        public bool Btn_AddNewHAWB { get; set; }
        // update by standard on 2019/11/27 Item 111
        public bool AEURL { get; set; }

        public bool Btn_AddNewSMAWB { get; set; }

        public bool Btn_AddEntry { get; set; }

        public bool Btn_CopyFromHAWB { get; set; }


        [StringLength(20)]
        public string PreAlertUser { get; set; }

        public DateTime? PreAlertDate { get; set; }

        [StringLength(10)]
        public string Status { get; set; }


        [StringLength(10)]
        public string ServiceLevel { get; set; }


        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }


        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool Btn_ArriveNoticeAlertMAWBOnly { get; set; }

        [StringLength(10)]
        public string SStationID { get; set; }

        [StringLength(50)]
        public string ShptType { get; set; }

        [StringLength(50)]
        public string ReferenceCode { get; set; }

        [StringLength(20)]
        public string SPL { get; set; }

        [StringLength(10)]
        public string IMPStation { get; set; }

        [StringLength(20)]
        public string BKNO { get; set; }

        [StringLength(500)]
        public string ConfirmID { get; set; }

        [StringLength(50)]
        public string HSCode { get; set; }

        [StringLength(50)]
        public string UNCode { get; set; }

        [StringLength(15)]
        public string MTSNO { get; set; }

        public int? ImportAgent { get; set; }

        public int? SourceID { get; set; }

        [StringLength(50)]
        public string FRTParty { get; set; }

        [StringLength(3)]
        public string DBID { get; set; }



        public int? CopyAIID { get; set; }

        public string customerCode { get; set; }

        public AI_HAWB_WarehouseViewModel warehouse { get; set; }

        public AI_HAWB_HeaderViewModel header { get; set; }

        public AI_HAWB_MovementViewModel movement { get; set; }

        public AI_HAWB_InstructionViewModel Instruction { get; set; }
        public AI_HAWB_BookingViewModel booking { get; set; }
        public AI_HAWB_CustomsViewModel customs { get; set; }
        public AI_HAWB_GoodsViewModel goods { get; set; }
        public AI_HAWB_ExtraViewModel extra { get; set; }
        public AI_HAWB_SHAWBViewModel SHAWB { get; set; }

        public AI_HAWB_ConsollistViewModel consolDetail { get; set; }

        ///<summary>
        ///Shipper
        ///</summary>
        public int? Shipper { get; set; }

        ///<summary>
        ///CNEE
        ///</summary>
        public int? CNEE { get; set; }

        ///<summary>
        ///Notify
        ///</summary>
        public int? Notify { get; set; }

        ///<summary>
        ///Sales
        ///</summary>
        public string Sales { get; set; }

        ///<summary>
        ///FRT
        ///</summary>
        public string FRT { get; set; }

        ///<summary>
        ///Other
        ///</summary>
        public string Other { get; set; }

        ///<summary>
        ///Move
        ///</summary>
        public string Move { get; set; }

        ///<summary>
        ///ActPCS
        ///</summary>
        public int? ActPCS { get; set; }

        public Boolean btnCBSeManifest { get; set; }

        ///<summary>
        ///SPUnit
        ///</summary>
        public int? SPUnit { get; set; }

        ///<summary>
        ///SPUnitUOM
        ///</summary>
        public string SPUnitUOM { get; set; }

        ///<summary>
        ///GWT
        ///</summary>
        public double? GWT { get; set; }

        ///<summary>
        ///VWT
        ///</summary>
        public double? VWT { get; set; }

        ///<summary>
        ///CWT
        ///</summary>
        public double? CWT { get; set; }

        ///<summary>
        ///WTUOM
        ///</summary>
        public string WTUOM { get; set; }

        ///<summary>
        ///ClassRate
        ///</summary>
        public string ClassRate { get; set; }

        ///<summary>
        ///Rate
        ///</summary>
        public double? Rate { get; set; }

        ///<summary>
        ///Currency
        ///</summary>
        public string Currency { get; set; }

        ///<summary>
        ///ShowRate
        ///</summary>
        public bool ShowRate { get; set; }

        ///<summary>
        ///ExportLIC
        ///</summary>
        public string ExportLIC { get; set; }

        ///<summary>
        ///Quantity
        ///</summary>
        public string Quantity { get; set; }

        ///<summary>
        ///CommInv
        ///</summary>
        public string CommInv { get; set; }

        ///<summary>
        ///DESC
        ///</summary>
        public string DESC { get; set; }

        ///<summary>
        ///Remark
        ///</summary>
        public string Remark { get; set; }

        ///<summary>
        ///Marks
        ///</summary>
        public string Marks { get; set; }

        ///<summary>
        ///SPINST
        ///</summary>
        public string SPINST { get; set; }
        
        ///<summary>
        ///ThirdParty
        ///</summary>
        public int? ThirdParty { get; set; }

        ///<summary>
        ///PortOfDEPT
        ///</summary>
        public int? PortOfDEPT { get; set; }

        ///<summary>
        ///PortOfDSTN
        ///</summary>
        public int? PortOfDSTN { get; set; }

        ///<summary>
        ///PlaceOfRCPT
        ///</summary>
        public int? PlaceOfRCPT { get; set; }

        ///<summary>
        ///PlaceOfDELV
        ///</summary>
        public int? PlaceOfDELV { get; set; }

        ///<summary>
        ///TradeTerm
        ///</summary>
        public string TradeTerm { get; set; }
        
        ///<summary>
        ///ActPCSUOM
        ///</summary>
        public string ActPCSUOM { get; set; }
        
        ///<summary>
        ///ShippedWT
        ///</summary>
        public double? ShippedWT { get; set; }

        ///<summary>
        ///ShippedPCS
        ///</summary>
        public int? ShippedPCS { get; set; }

        ///<summary>
        ///SCHReleaseNo
        ///</summary>
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PODReleaseNo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string SCHReleaseNo { get; set; }

        ///<summary>
        ///SCHReleaseDate
        ///</summary>
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.SCHReleaseDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? SCHReleaseDate { get; set; }

        ///<summary>
        ///SCHNotifyParty
        ///</summary>
        public int? SCHNotifyParty { get; set; }

        ///<summary>
        ///SCHNotifyDate
        ///</summary>
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PODNotifyDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public DateTime? SCHNotifyDate { get; set; }

        ///<summary>
        ///SCHDocReleaseParty
        ///</summary>
        public int? SCHDocReleaseParty { get; set; }

        ///<summary>
        ///SCHDocReleaseDate
        ///</summary>
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PODDocReleaseDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public DateTime? SCHDocReleaseDate { get; set; }

        ///<summary>
        ///SCHDocReleaseType
        ///</summary>
        public string SCHDocReleaseType { get; set; }

        ///<summary>
        ///SCHNotifyType
        ///</summary>
        public string SCHNotifyType { get; set; }

        ///<summary>
        ///SCHCargoSignBy
        ///</summary>
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PODCargoSignBy), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string SCHCargoSignBy { get; set; }


        ///<summary>
        ///SCHLicenseDate
        ///</summary>
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PODLicenseDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public DateTime? SCHLicenseDate { get; set; }

        ///<summary>
        ///SCHCustomDate
        ///</summary>
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PODCustomDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public DateTime? SCHCustomDate { get; set; }

        ///<summary>
        ///SCHDocSignBy
        ///</summary>
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PODDocSignBy), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string SCHDocSignBy { get; set; }

        ///<summary>
        ///SCHCargoReleaseParty
        ///</summary>
        public int? SCHCargoReleaseParty { get; set; }

        ///<summary>
        ///SCHCargoReleaseDate
        ///</summary>
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PODCargoReleaseDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public DateTime? SCHCargoReleaseDate { get; set; }

        ///<summary>
        ///SCHCargoReleaseType
        ///</summary>
        public string SCHCargoReleaseType { get; set; }

        public string SCHNotifyPartyCode { get; set; }

        public string SCHDocReleasePartyCode { get; set; }

        public string SCHCargoReleasePartyCode { get; set; }

        public string Mode { get; set; }

        ///<summary>
        ///CustomsDeclareParty
        ///</summary>
        public int? CustomsDeclareParty { get; set; }

        ///<summary>
        ///CustomsHandledBy
        ///</summary>
        public int? CustomsHandledBy { get; set; }

        ///<summary>
        ///CustomsDocType
        ///</summary>
        public string CustomsDocType { get; set; }

        ///<summary>
        ///CustomsAvaDate
        ///</summary>
        public DateTime? CustomsAvaDate { get; set; }

        ///<summary>
        ///CustomsDecDate
        ///</summary>
        public DateTime? CustomsDecDate { get; set; }

        ///<summary>
        ///CustomsRemark
        ///</summary>
        public string CustomsRemark { get; set; }

        ///<summary>
        ///CustomsStatus
        ///</summary>
        public string CustomsStatus { get; set; }

        ///<summary>
        ///WHActPCS
        ///</summary>
        public int? WHActPCS { get; set; }

        ///<summary>
        ///WHActPCSUOM
        ///</summary>
        public string WHActPCSUOM { get; set; }

        ///<summary>
        ///WHActWT
        ///</summary>
        public double? WHActWT { get; set; }

        ///<summary>
        ///WHActWTUOM
        ///</summary>
        public string WHActWTUOM { get; set; }

        ///<summary>
        ///WHActVWT
        ///</summary>
        public double? WHActVWT { get; set; }

        ///<summary>
        ///WHActVWTUOM
        ///</summary>
        public string WHActVWTUOM { get; set; }

        ///<summary>
        ///WHLocation
        ///</summary>
        public string WHLocation { get; set; }

        ///<summary>
        ///WHArrivalDate
        ///</summary>
        public DateTime? WHArrivalDate { get; set; }

        ///<summary>
        ///WHPulloutDate
        ///</summary>
        public DateTime? WHPulloutDate { get; set; }

        ///<summary>
        ///WHContainer
        ///</summary>
        public string WHContainer { get; set; }

        ///<summary>
        ///WHRemark
        ///</summary>
        public string WHRemark { get; set; }

        ///<summary>
        ///WHCargoStatus
        ///</summary>
        public string WHCargoStatus { get; set; }
        
        ///<summary>
        ///WHReceiptNo
        ///</summary>
        public string WHReceiptNo { get; set; }
        
        ///<summary>
        ///isIT
        ///</summary>
        public bool isIT { get; set; }
        
        ///<summary>
        ///PODTemplate
        ///</summary>
        public string PODTemplate { get; set; }

        ///<summary>
        ///SCHCargoTerminalDate
        ///</summary>
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.SCHCargoTerminalDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public DateTime? SCHCargoTerminalDate { get; set; }
        
        ///<summary>
        ///HBroker
        ///</summary>
        public int? HBroker { get; set; }
        
        ///<summary>
        ///CopyAEBy
        ///</summary>
        public string CopyAEBy { get; set; }

        ///<summary>
        ///CopyAEDate
        ///</summary>
        public DateTime? CopyAEDate { get; set; }

        ///<summary>
        ///CopyAEID
        ///</summary>
        public int? CopyAEID { get; set; }

        public AI_HAWB_ScheduleViewModel Schedule { get; set; }

        #region Button Operation
        public bool Btn_Save { get; set; }
        public bool Btn_SaveExit { get; set; }
        public bool Btn_Void { get; set; }
        private string _Btn_VoidText = "Void";
        public string Btn_VoidText { get { return _Btn_VoidText; } set { _Btn_VoidText = value; } }
        public bool Btn_Close { get; set; }
        public bool Btn_Bookmark { get; set; }        
        public bool Btn_eCall { get; set; }
        public bool Btn_POD { get; set; }
        public bool Btn_CopytoAE { get; set; }
        public bool Btn_MilestoneHistory { get; set; }
        public bool Btn_InputOtherMilestone { get; set; }
        public bool Btn_SCHCargoReleaseParty { get; set; }
        public bool Btn_SCHDocReleaseParty { get; set; }
        public bool Btn_SCHNotifyType { get; set; }
        public bool Btn_EDI { get; set; }
        public bool Btn_Prealert { get; set; }
        public string Btn_PrealertMessage { get; set; }

        public string bookedString { get; set; }
        public string shipmentString { get; set; }

        public bool Btn_PostSales { get; set; }
        public bool Btn_Dimension { get; set; }

        public bool Btn_SubTotal { get; set; }
        public bool Btn_CBSeManifest { get; set; }
        #endregion Button Operation

        #region URL
        public string url_Prealert
        {
            get; set;
        }
        public string url_CopytoAE
        {
            get; set;
        }
        public string url_PostSales
        {
            get; set;
        }
        public string url_Preview
        {
            get; set;
        }
        public string url_PreviewAllHAWBs
        {
            get; set;
        }
        public string url_DimensionURL
        {
            get; set;
        }

        public string url_MilestoneHistory
        {
            get; set;
        }

        public string url_InputOtherMilestone
        {
            get; set;
        }

        public string url_POD
        {
            get; set;
        }
        
        //Add by Harry @ 2019/08/22, merge AIOI source code and update poms for VAL-2431.
        public string URL_POMS { get; set; }

        #endregion URL

        #region Tab Display

        private bool _tab_Shipment { get; set; }
        private bool _tab_Quotation { get; set; }
        private bool _AuthToMakeEntry { get; set; }
        private bool _tab_Preview { get; set; }
        private bool _tab_SalesCost { get; set; }
        private bool _tab_Pickup { get; set; }
        private bool _tab_Summary { get; set; }
        private bool _tab_7512 { get; set; }
        private bool _tab_AutoToMakeEntry { get; set; }
        private bool _panelbar_CarrierBooking { get; set; } //add by Royal @ 2018/8/7
        private bool _panelbar_IrrReason { get; set; }
        private bool _panelbar_Prealert { get; set; }
        private bool _tab_ArriveNotice { get; set; }
        public bool tab_Shipment { get { setTabStatus(); return _tab_Shipment; }  }       
        public bool tab_Quotation { get { setTabStatus();  return _tab_Quotation; } }
        public bool AuthToMakeEntry { get { setTabStatus(); return _AuthToMakeEntry; } }
        public bool tab_Preview { get { setTabStatus(); return _tab_Preview; } }
        public bool tab_SalesCost { get { setTabStatus(); return _tab_SalesCost; } }
        public bool tab_Pickup { get { setTabStatus(); return _tab_Pickup; } }
        public bool tab_Summary { get { setTabStatus(); return _tab_Summary; } }
        public bool tab_7512 { get { setTabStatus(); return _tab_Summary; } }
        public bool tab_AutoToMakeEntry { get { setTabStatus(); return _tab_Summary; } }
        public bool tab_Prealert { get { setTabStatus(); return _tab_Summary; } }
        public bool tab_ArriveNotice { get { setTabStatus(); return _tab_ArriveNotice; } }

        private void setTabStatus()
        {
            switch (Status)
            {
                case (AMSStatus.AWB_DRAFT):
                    _tab_Shipment = true;
                    _tab_Quotation = true;
                    _tab_Preview = true;
                    _tab_SalesCost = true;
                    _tab_Pickup = true;
                    _tab_Summary = true;
                    _tab_7512 = false;
                    _tab_AutoToMakeEntry = true;
                    _tab_ArriveNotice = true;
                    _AuthToMakeEntry = true;
                    break;
                case (AMSStatus.AWB_OPEN):
                    _tab_Shipment = true;
                    _tab_Quotation = true;
                    _AuthToMakeEntry = true;
                    _tab_Preview = true;
                    _tab_SalesCost = true;
                    _tab_Pickup = true;
                    _tab_Summary = true;
                    _tab_7512 = true;
                    _tab_AutoToMakeEntry = true;
                    _tab_ArriveNotice = true;
                    break;
                case (AMSStatus.AWB_CLOSE):
                    _tab_Shipment = true;
                    _tab_Quotation = true;
                    _AuthToMakeEntry = true;
                    _tab_Preview = true;
                    _tab_SalesCost = true;
                    _tab_Pickup = true;
                    _tab_Summary = true;
                    _tab_7512 = true;
                    _tab_ArriveNotice = true;
                    _tab_AutoToMakeEntry = true;
                    break;
                default:
                    _tab_Shipment = true;
                    _tab_Quotation = false;
                    _tab_Preview = false;
                    _tab_SalesCost = false;
                    _tab_Pickup = false;
                    _tab_Summary = false;
                    _tab_7512 = false;
                    _tab_AutoToMakeEntry = false;
                    _tab_ArriveNotice = false;
                    _AuthToMakeEntry = false;
                    break;
            }
        }
        #endregion

        #region Panelbar Display

        private bool _panelbar_QuickEntry { get; set; }
        private bool _panelbar_Consolidation { get; set; }
        private bool _panelbar_Movement { get; set; }
        private bool _panelbar_Goods { get; set; }
        private bool _panelbar_Warehouse { get; set; }
        private bool _panelbar_Customs { get; set; }
        private bool _panelbar_Instruction { get; set; }
        private bool _panelbar_PO { get; set; }
        private bool _panelbar_DocumentCloud { get; set; }
        private bool _panelbar_SHAWB { get; set; }
        private bool _panelbar_Schedule { get; set; }
        private bool _panelbar_Reason { get; set; }
        private bool _panelbar_OrderPoManagenment { get; set; }
        private bool _panelbar_Extra { get; set; }
        private bool _panelbar_Information { get; set; }
        private bool _panelbar_Delivery { get; set; }
        public bool panelbar_CarrierBooking { get { setPanelbarStatus(); return _panelbar_CarrierBooking; } }//add by Royal @ 2018/8/7
        public bool panelbar_QuickEntry { get { setPanelbarStatus(); return _panelbar_QuickEntry; } }
        public bool panelbar_Consolidation { get { setPanelbarStatus(); return _panelbar_Consolidation; } }
        public bool panelbar_Movement { get { setPanelbarStatus(); return _panelbar_Movement; } }

        public bool panelbar_Reason { get { setPanelbarStatus(); return _panelbar_Reason; } }
        public bool panelbar_OrderPoManagenment { get { setPanelbarStatus(); return _panelbar_OrderPoManagenment; } }
        public bool panelbar_Information { get { setPanelbarStatus(); return _panelbar_Information; } }
        public bool panelbar_Delivery { get { setPanelbarStatus(); return _panelbar_Delivery; } }
        public bool panelbar_Goods { get { setPanelbarStatus(); return _panelbar_Goods; } }
        public bool panelbar_Warehouse { get { setPanelbarStatus(); return _panelbar_Warehouse; } }
        public bool panelbar_Customs { get { setPanelbarStatus(); return _panelbar_Customs; } }
        public bool panelbar_Instruction { get { setPanelbarStatus(); return _panelbar_Instruction; } }
        public bool panelbar_PO { get { setPanelbarStatus(); return _panelbar_PO; } }
        public bool panelbar_DocumentCloud { get { setPanelbarStatus(); return _panelbar_DocumentCloud; } }
        public bool panelbar_SHAWB { get { setPanelbarStatus(); return _panelbar_SHAWB; } }
        public bool panelbar_Schedule { get { setPanelbarStatus(); return _panelbar_Schedule; } }
        public bool panelbar_Extra { get { setPanelbarStatus(); return _panelbar_Extra; } }
        public bool panelbar_IrrReason { get { setPanelbarStatus(); return _panelbar_IrrReason; } }
        public bool panelbar_Prealert { get { setPanelbarStatus(); return _panelbar_Prealert; } }
        private void setPanelbarStatus()
        {
            switch (Status)
            {
                case (AMSStatus.AWB_DRAFT):
                    _panelbar_QuickEntry = false;
                    _panelbar_Consolidation = false;
                    _panelbar_Movement = true;
                    _panelbar_Goods = true;
                    _panelbar_Warehouse = true;
                    _panelbar_Customs = true;
                    _panelbar_Instruction = true;
                    _panelbar_PO = true;
                    _panelbar_DocumentCloud = true;
                    _panelbar_SHAWB = false;
                    _panelbar_Schedule = false;
                    _panelbar_Prealert = true;

                    _panelbar_Reason = true;
                    _panelbar_OrderPoManagenment = true;
                    _panelbar_Extra = true;
                    _panelbar_Information = true;
                    _panelbar_Delivery = true;
                    break;
                case (AMSStatus.AWB_OPEN):
                    _panelbar_QuickEntry = true;
                    _panelbar_Consolidation = false;
                    _panelbar_Movement = true;
                    _panelbar_Goods = true;
                    _panelbar_Warehouse = true;
                    _panelbar_Customs = true;
                    _panelbar_Instruction = true;
                    _panelbar_PO = true;
                    _panelbar_DocumentCloud = true;
                    _panelbar_SHAWB = false;
                    _panelbar_Schedule = true;

                    _panelbar_Reason = true;
                    _panelbar_OrderPoManagenment = true;
                    _panelbar_Extra = true;
                    _panelbar_Information = true;
                    _panelbar_Delivery = true;

                    break;
                case (AMSStatus.AWB_CLOSE):
                    _panelbar_QuickEntry = false;
                    _panelbar_Consolidation = false;
                    _panelbar_Movement = true;
                    _panelbar_Goods = true;
                    _panelbar_Warehouse = true;
                    _panelbar_Customs = true;
                    _panelbar_Instruction = true;
                    _panelbar_PO = true;
                    _panelbar_DocumentCloud = true;
                    _panelbar_SHAWB = false;
                    _panelbar_Schedule = true;

                    _panelbar_Reason = true;
                    _panelbar_OrderPoManagenment = true;
                    _panelbar_Extra = true;
                    _panelbar_Information = true;
                    _panelbar_Delivery = true;
                    break;
                default:
                    _panelbar_QuickEntry = false;
                    _panelbar_Consolidation = false;
                    _panelbar_Movement = true;
                    _panelbar_Goods = true;
                    _panelbar_Warehouse = false;
                    _panelbar_Customs = false;
                    _panelbar_Instruction = true;
                    _panelbar_PO = false;
                    _panelbar_DocumentCloud = false;
                    _panelbar_SHAWB = false;
                    _panelbar_Schedule = false;
                    _panelbar_Prealert = false;

                    _panelbar_Reason = false;
                    _panelbar_OrderPoManagenment = false;
                    _panelbar_Extra = false;
                    _panelbar_Information = false;
                    _panelbar_Delivery = false;
                    break;
            }
        }
        #endregion

        #region Set HAWBNo label name
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.HAWBNo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        private string _lableHAWBNoName { get; set; }

        public string lableHAWBNoName { get { setHAWBNoName(); return _lableHAWBNoName; } }

        public string MAWBNo { get; set; }
        public string LotNo { get; set; }

        private void setHAWBNoName()
        {

            switch (Status)
            {
                case (AMSStatus.AWB_DRAFT):
                    _lableHAWBNoName = "Booking#";
                    break;
                default:
                    _lableHAWBNoName = "HAWB#";
                    break;
            }
        }

        #endregion 
    }
}

