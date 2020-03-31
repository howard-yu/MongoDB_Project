using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add by Amy @ 2018/9/5 add carrier booking btn
//add by Amy @ 2019/7/26 VAL-2431 To get POMS URL
//add by @ 2019/9/3 VAL-2787 After confirmed DAWB, user will key in carrier booking.
//update by Amanda @ 2019/10/15 for DAWB onboard Status add VAL-3424
namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_DAWBViewModel : ViewModelBase
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string StationID { get; set; }
        [StringLength(10)]
        public string SStationID { get; set; }
        [StringLength(3)]
        public string DBID { get; set; }
        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        [StringLength(500)]
        public string ConfirmID { get; set; }
        [StringLength(50)]
        public string ShptType { get; set; }

        [StringLength(50)]
        public string ReferenceCode { get; set; }

        [StringLength(10)]
        public string IMPStation { get; set; }
        [StringLength(20)]
        public string PreAlertUser { get; set; }

        public DateTime? PreAlertDate { get; set; }
        public string CYMNO { get; set; }
        public string AWBType { get; set; }
        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public AE_DAWB_HeaderViewModel header { get; set; }

        public AE_DAWB_MovementViewModel movement { get; set; }

        public AE_DAWB_GoodsViewModel goods { get; set; }

        public AE_HAWB_BookingViewModel booking { get; set; }

        public AE_HAWB_WarehouseViewModel warehouse { get; set; }

        public AE_HAWB_CustomsViewModel customs { get; set; }

        public AE_HAWB_InstructionViewModel instruction { get; set; }
        public AE_HAWB_ExtraViewModel extra { get; set; }
      
        public bool Btn_CarrierbookEdit { get; set; }   //add by Amy @ 2018/9/5
        public bool Btn_CarrierbookDestroy { get; set; } //add by Amy @ 2018/9/5

        //add by Amanda @ 2019/10/15 VAL-3424
        public bool Btn_OnBoardDetailAdd { get; set; }

        #region Button Operation
        public bool Btn_Print { get; set; }
        public bool Btn_Save { get; set; }
        public bool Btn_SaveExit { get; set; }
        public bool Btn_Bookmark { get; set; }
        public bool Btn_Void { get; set; }
        public bool Btn_Close { get; set; }
        private string Btn_CloseText = "Close";
        public bool Btn_Delete { get; set; }
        private string _Btn_VoidText = "Void";
        public string Btn_VoidText { get { return _Btn_VoidText; } set { _Btn_VoidText = value; } }
        public bool Btn_Confirm { get; set; }
        private string _Btn_ConfirmText = "Confirm";
        public string Btn_ConfirmText { get { return _Btn_ConfirmText; } set { _Btn_ConfirmText = value; } }
        public bool Btn_PostSales { get; set; }
        public bool Btn_PostCost { get; set; }
        public bool Btn_Dimension { get; set; }
        public bool Btn_eCall { get; set; }
        public bool Btn_MilestoneHistory { get; set; }
        public bool Btn_InputOtherMilestone { get; set; }
        public bool Btn_POD { get; set; }
        public bool Btn_Prealert { get; set; }
        public string Btn_PrealertMessage { get; set; }
        public bool Btn_eManifest { get; set; }
        public bool Btn_ReOpen { get; set; }
        #endregion Button Operation



        #region URL
        public string url_Prealert
        {
            get; set;
        }
        public string url_PostSales
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
        //add by Amy @ 2019/7/26 VAL-2431 To get POMS URL
        public string URL_POMS { get; set; }
        #endregion URL

        #region Tab Display

        private bool _tab_Shipment { get; set; }
        private bool _tab_Quotation { get; set; }
        private bool _tab_Preview { get; set; }
        private bool _tab_SalesCost { get; set; }
        private bool _tab_Pickup { get; set; }
        private bool _tab_Summary { get; set; }

      
       
        #endregion

        #region Panelbar Display

        private bool _panelbar_QuickEntry { get; set; }
        private bool _panelbar_Milestone { get; set; }
        private bool _panelbar_Booking { get; set; }
        private bool _panelbar_Movement { get; set; }
        private bool _panelbar_Goods { get; set; }
        private bool _panelbar_Warehouse { get; set; }
        private bool _panelbar_Customs { get; set; }
        private bool _panelbar_Instruction { get; set; }
        private bool _panelbar_CarrierBook { get; set; }
        private bool _panelbar_PO { get; set; }
        private bool _panelbar_DocumentCloud { get; set; }
        private bool _panelbar_IrregularReason { get; set; }
        private bool _panelbar_Extra { get; set; }


        #endregion
    }
}

