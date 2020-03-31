using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Update by Amy @ 2018/7/16 VAL-981 add btn_SendeAWB Borrow out no need to show this button.
namespace ValuePlus.ViewModel.LocaleChainVP
{
    /// <summary>
    /// Update by Royal @ 2018/8/20 Add SMAWB Page ,VAL-861
    /// </summary>
    public class AE_MAWBViewModel : ViewModelBase
    {

        public int ID { get; set; }

     
        [StringLength(10)]
        public string StationID { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CYMNO { get; set; }

        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }


        public AE_MAWB_ConsolDetailViewModel consolDetail { get; set; }

        public AE_MAWB_HeaderViewModel header { get; set; }

        //update by Royal @ 2018/8/20 replace AE_MAWB_SMAWBViewModel to AE_SMAWBViewModel
        public AE_SMAWBViewModel smawb { get; set; }

        public AE_MAWB_CarrierBookingViewModel carrierBooking { get; set; }

        #region ReadOnly Operation

        public bool addSMAWBRead { get; set; }

        #endregion


        #region Button Operation

        public bool Btn_Save { get; set; }
        public bool Btn_SaveExit { get; set; }
        public bool Btn_Bookmark { get; set; }
        public bool Btn_Void { get; set; }
        private string _Btn_VoidText = "Void";
        public string Btn_VoidText { get { return _Btn_VoidText; } set { _Btn_VoidText = value; } }

        public bool Btn_CYM { get; set; }
        
        [System.ComponentModel.DefaultValue("CYM")]
        public string Btn_CYMMessage { get; set; }

        public bool Btn_eManifest { get; set; }
        private string _Btn_eManifest = "eManifest";
        public string Btn_eManifestText { get { return _Btn_eManifest; } set { _Btn_eManifest = value; } }
        public string Btn_eManifestMessage { get; set; }

        public bool Btn_PrealertMAWBOnly { get; set; }
        public string Btn_PrealertMAWBOnlyMessage { get; set; }

        public bool Btn_PrealertAllHAWB { get; set; }
        public string Btn_PrealertAllHAWBMessage { get; set; }

        public bool Btn_Close { get; set; }
        public bool Btn_PostSales { get; set; }
        public bool Btn_PostLocalCharge { get; set; }
        public bool Btn_ReOpen { get; set; }

        public bool Btn_Dimension { get; set; }

        public bool Btn_BuildConsol { get; set; }

        public bool Btn_AddNewSMAWB { get; set; }

        //add by Amy @ 2018/7/16 
        public bool Btn_SendeAWB { get; set; }
        
        //add by Kenny @ 2018/8/28
        public bool Btn_CarrierbookEdit { get; set; }

        //add by Kenny @ 2018/8/28
        public bool Btn_CarrierbookDestroy { get; set; }

        //add by Amanda @ 2019/8/1
        public bool Btn_OnBoardDetailAdd { get; set; }
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

        public string url_eManifest
        {
            get; set;
        }

        #endregion URL

        #region Tab Display

        private bool _tab_Shipment { get; set; }     
        private bool _tab_Preview { get; set; }
        private bool _tab_SalesCost { get; set; }
        private bool _tab_Pickup { get; set; }
        private bool _tab_Summary { get; set; }


       
        #endregion

        #region Panelbar Display

        private bool _panelbar_Action { get; set; }
        private bool _panelbar_ShipmentDetail { get; set; }
        private bool _panelbar_Instruction { get; set; }
        private bool _panelbar_CarrierBooking { get; set; }
        private bool _panelbar_ShipmentRecord { get; set; }
        private bool _panelbar_IrrReason { get; set; }

        #endregion

    }
}

