using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_MAWBViewModel : ViewModelBase
    {

        public int ID { get; set; }

     
        [StringLength(10)]
        public string StationID { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string DYMNO { get; set; }

        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }


        public AI_MAWB_ConsolDetailViewModel consolDetail { get; set; }

        public AI_MAWB_HeaderViewModel header { get; set; }

        public AI_MAWB_ConsollistViewModel mConsolList { get; set; }

        public AI_MAWB_CarrierBookingViewModel carrierBooking { get; set; }

        //add by Kenny @ 2018/8/28
        public bool Btn_CarrierbookEdit { get; set; }

        //add by Kenny @ 2018/8/28
        public bool Btn_CarrierbookDestroy { get; set; }

        #region ReadOnly Operation

        public bool addSMAWBRead { get; set; }

        #endregion


        #region Button Operation

        public bool Btn_Save { get; set; }
        public bool Btn_SaveExit { get; set; }
        //public bool Btn_Bookmark { get; set; }
        public bool Btn_Void { get; set; }
        private string _Btn_VoidText = "Void";
        public string Btn_VoidText { get { return _Btn_VoidText; } set { _Btn_VoidText = value; } }

        public bool Btn_DYM { get; set; }
        
        [System.ComponentModel.DefaultValue("DYM")]
        public string Btn_DYMMessage { get; set; }

        //public bool Btn_eManifest { get; set; }
        //private string _Btn_eManifest = "eManifest";
        //public string Btn_eManifestText { get { return _Btn_eManifest; } set { _Btn_eManifest = value; } }
        //public string Btn_eManifestMessage { get; set; }

        public bool Btn_ArriveNoticeAlertMAWBOnly { get; set; }
        public string Btn_ArriveNoticeAlertMAWBOnlyMessage { get; set; }

        public bool Btn_ArriveNoticeAllHAWB { get; set; }
        public string Btn_ArriveNoticeAllHAWBMessage { get; set; }

        public bool Btn_Close { get; set; }
        //public bool Btn_PostSales { get; set; }
        public bool Btn_PostLocalCharge { get; set; }
        public bool Btn_ReOpen { get; set; }

        public bool Btn_Dimension { get; set; }

        public bool Btn_AddNewHAWB { get; set; }

        public bool Btn_AddNewSMAWB { get; set; }

        public bool Btn_AddEntry { get; set; }

        public bool Btn_CopyFromHAWB { get; set; }

        #endregion Button Operation

        #region URL
        public string url_Preview
        {
            get; set;
        }
        public string url_PreviewMAWBOnly
        {
            get; set;
        }
        public string url_PreviewAllHAWBs
        {
            get; set;
        }

        public string url_SalesCost
        {
            get; set;
        }

        public string url_Summary
        {
            get; set;
        }

        public string url_PostLocalCharge
        {
            get; set;
        }

        public string url_DimensionURL
        {
            get;set;
        }

        public string url_AddNewHAWB
        {
            get;set;
        }

        public string url_AddNewSMAWB
        {
            get;set;
        }
        

        #endregion URL

        #region Tab Display

        private bool _tab_Shipment { get; set; }     
        private bool _tab_Preview { get; set; }
        private bool _tab_SalesCost { get; set; }
        private bool _tab_Summary { get; set; }

        public bool tab_Shipment { get { setTabStatus(); return _tab_Shipment; }  }               
        public bool tab_Preview { get { setTabStatus(); return _tab_Preview; } }
        public bool tab_SalesCost { get { setTabStatus(); return _tab_SalesCost; } }
        public bool tab_Summary { get { setTabStatus(); return _tab_Summary; } }

        private void setTabStatus()
        {
            switch (Status)
            {
                case (AMSStatus.AWB_DRAFT):
                    _tab_Shipment = true;                 
                    _tab_Preview = false;
                    _tab_SalesCost = false;
                    _tab_Summary = false;
                    break;
                case (AMSStatus.AWB_OPEN):
                    _tab_Shipment = true;
                    _tab_Preview = true;
                    _tab_SalesCost = true;
                    _tab_Summary = true;
                    break;
                case (AMSStatus.AWB_CLOSE):
                    _tab_Shipment = true;
                    _tab_Preview = true;
                    _tab_SalesCost = true;
                    _tab_Summary = true;
                    break;
                default:
                    _tab_Shipment = true;
                    _tab_Preview = false;
                    _tab_SalesCost = false;
                    _tab_Summary = false;
                    break;
            }
            if (this.header.MAWBLotNo == "" || this.header.MAWBLotNo == null || this.header.MAWBLotNo == "ZZZZZZZZZ")
                this._tab_SalesCost = false;
        }
        #endregion

        #region Panelbar Display

        private bool _panelbar_Action { get; set; }
        private bool _panelbar_ShipmentDetail { get; set; }
        private bool _panelbar_Instruction { get; set; }
        private bool _panelbar_CarrierBooking { get; set; }
        private bool _panelbar_ShipmentRecord { get; set; }
        private bool _panelbar_ConsolList { get; set; }
        private bool _panelbar_IrrReason { get; set; }
        private bool _panelbar_FlightInfo { get; set; }

        public bool panelbar_QuickEntry { get { setPanelbarStatus(); return _panelbar_Action; } }
        public bool panelbar_Consolidation { get { setPanelbarStatus(); return _panelbar_ShipmentDetail; } }
        public bool panelbar_Instruction { get { setPanelbarStatus(); return _panelbar_Instruction; } }
        public bool panelbar_ConsolList { get { setPanelbarStatus(); return _panelbar_ConsolList; } }
        public bool panelbar_IrrReason { get { setPanelbarStatus(); return _panelbar_IrrReason; } }
        public bool panelbar_FlightInfo { get { setPanelbarStatus(); return _panelbar_FlightInfo; } }

        private void setPanelbarStatus()
        {
            switch (Status)
            {
                case (AMSStatus.AWB_DRAFT):
                    _panelbar_Action = true;
                    _panelbar_ShipmentDetail = true;
                    _panelbar_Instruction = true;
                    _panelbar_CarrierBooking = true;
                    _panelbar_ShipmentRecord = true;
                    _panelbar_ConsolList = true;
                    _panelbar_IrrReason = true;
                    _panelbar_FlightInfo = true;

                    break;
                case (AMSStatus.AWB_OPEN):
                    _panelbar_Action = true;
                    _panelbar_ShipmentDetail = true;
                    _panelbar_Instruction = true;
                    _panelbar_CarrierBooking = true;
                    _panelbar_ShipmentRecord = true;
                    _panelbar_ConsolList = true;
                    _panelbar_IrrReason = true;
                    _panelbar_FlightInfo = true;
                    break;
                case (AMSStatus.AWB_CLOSE):
                    _panelbar_Action = true;
                    _panelbar_ShipmentDetail = true;
                    _panelbar_Instruction = true;
                    _panelbar_CarrierBooking = true;
                    _panelbar_ShipmentRecord = true;
                    _panelbar_ConsolList = true;
                    _panelbar_IrrReason = true;
                    _panelbar_FlightInfo = true;
                    break;
                default:
                    _panelbar_Action = true;
                    _panelbar_ShipmentDetail = true;
                    _panelbar_Instruction = false;
                    _panelbar_CarrierBooking = false;
                    _panelbar_ShipmentRecord = false;
                    _panelbar_ConsolList = false;
                    _panelbar_IrrReason = false;
                    _panelbar_FlightInfo = false;
                    break;
            }
        }
        #endregion

    }
}

