using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_MovementViewModel : ViewModelBase
    {

        [Required(ErrorMessage = "P.Receipt is mandatory")]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PlaceofRECP), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? pOfRecID { get; set; }

        [Required(ErrorMessage = "P.DEPT is mandatory")]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PortOfDeptID), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? pOfDEPTID { get; set; }

        [Required(ErrorMessage = "P.Delivery is mandatory")]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PlaceofDELV), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? pOfDevID { get; set; }

        [Required(ErrorMessage = "P.DSTN is mandatory")]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PortOfDSTN), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? pOfDSTNID { get; set; }
        //Add by Jane at 2019/10/16 Add AirPortOfDept,AirPortOfDstn,TransShipmentPort, VAL-1740
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.DEPTPort), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? AirPortOfDeptID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.DSTNPort), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? AirPortOfDstnID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.TransShipmentPort), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? TransShipmentPortID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.BBAgent), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? BBAgentID { get; set; }

        [Required(ErrorMessage = "SHPR is mandatory")]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.SHPR), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? SHPRID { get; set; }

        [Required(ErrorMessage = "CNEE is mandatory")]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CNEE), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? CNEEID { get; set; }

        [Display(Name = "BROKER")]
        public int? BrokerID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.NTFY), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? NTFYID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.ThirdPTY), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? thirtyPTYID { get; set; }

        public string SHPRAddr { get; set; }

        public string CNEEAddr { get; set; }

        public string NTFYAddr { get; set; }

        public string thirtyPTYAddr { get; set; }

        public string BROKERAddr { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.FinalImport), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public int? finalimportID { get; set; }

        [Required]
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.TradeTerm), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string tradeTerm { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PayTypeFRT), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string FRT { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.Common.Other), ResourceType = typeof(ValuePlus.Resource.Lang.Common))]
        public string Other { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Move), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string Move { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Salesperson), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string salespersonID { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.AvailableDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? avaDate { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.DepartureDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DepDate { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.ArrivalDate), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? ariDate { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.HandlingInfo), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string HandlingInfo { get; set; }
        public string HandlingInfoColor { get; set; }

        public String BrokerCode { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PlaceofRECP), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string pOfRec { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PortOfDeptID), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string pOfDEPT { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PlaceofDELV), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string pOfDev { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.PortOfDSTN), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string pOfDSTN { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.BBAgent), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string BBAgent { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.SHPR), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string SHPR { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.CNEE), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string CNEE { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.NTFY), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string NTFY { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Broker), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string BROKER { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.ThirdPTY), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string thirtyPTY { get; set;  }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.FinalImport), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string finalimport { get; set; }
        public string finalimportAddr { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.Salesperson), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string salesperson { get; set; }
        //Add by Jane at 2019/09/16 Add Parameter for Revise Milestone Mandatory/Sequence Control based Shipping Term,VAL-2867
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.ExportCustClearance), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public bool? ExportCustoms { get; set; }
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.ImportCustClearance), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public bool? ImportCustoms { get; set; }
        //Add by Jane at 2019/10/16 Add AirPortOfDept,AirPortOfDstn,TransShipmentPort, VAL-1740
        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.DEPTPort), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string AirPortOfDept { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.DSTNPort), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string AirPortOfDstn { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.TransShipmentPort), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public string TransShipmentPort { get; set; }

        [Display(Name = nameof(ValuePlus.Resource.Lang.AMS.NoExpected), ResourceType = typeof(ValuePlus.Resource.Lang.AMS))]
        public bool? NoExpect { get; set; }

        #region ReadOnly Operation

        public bool pReceiptRead { get; set; }
        public bool pDeptRead { get; set; }
        public bool pDstnRead { get; set; }
        public bool pDeliveryRead { get; set; }
        public bool bBAgentRead { get; set; }
        public bool termRead { get; set; }
        public bool payTypeRead { get; set; }
        public bool moveRead { get; set; }
        public bool thirdPTRead { get; set; }
        //Add by Jane at 2019/10/16 Add DEPTPort/DSTNPort/TransShipment enable or not, VAL-1740
        public bool pDEPTPortRead { get; set; }
        public bool pDSTNPortRead { get; set; }
        public bool pTransShipmentRead { get; set; }
        #endregion
    }
}
