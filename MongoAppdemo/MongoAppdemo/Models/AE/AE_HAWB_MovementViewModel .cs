using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_HAWB_MovementViewModel : ViewModelBase
    {
        [Required(ErrorMessage = "P.Receipt is mandatory")]
        public int? pOfRecID { get; set; }

        [Required(ErrorMessage = "P.DEPT is mandatory")]
        public int? pOfDEPTID { get; set; }

        [Required(ErrorMessage = "P.Delivery is mandatory")]
        public int? pOfDevID { get; set; }

        [Required(ErrorMessage = "P.DSTN is mandatory")]
        public int? pOfDSTNID { get; set; }

        public int? BBAgentID { get; set; }


        public int? AirPortOfDeptID { get; set; }

        public int? AirPortOfDstnID { get; set; }

        public int? TransShipmentPortID { get; set; }

        [Required(ErrorMessage = "SHPR is mandatory")]

        public int? SHPRID { get; set; }

        [Required(ErrorMessage = "CNEE is mandatory")]

        public int? CNEEID { get; set; }
        
        public int? NTFYID { get; set; }

        public int? thirtyPTYID { get; set; }
        
        public string SHPRAddr { get; set; }

        public string CNEEAddr { get; set; }

        public string NTFYAddr { get; set; }

        public string thirtyPTYAddr { get; set; }

        public int? finalimportID { get; set; }

        public string tradeTerm { get; set; }

        public string FRT { get; set; }

        public string Other { get; set; }

        public string Move { get; set; }

        public string salespersonID { get; set; }

        public DateTime? avaDate { get; set; }

        public DateTime? DepDate { get; set; }

        public DateTime? ariDate { get; set; }

        public string HandlingInfo { get; set; }
        public string HandlingInfoColor { get; set; }

      
        public string pOfRec { get; set; }
        
        public string pOfDEPT { get; set; }

        public string pOfDev { get; set; }
        

        public string pOfDSTN { get; set; }

        public string AirPortOfDept { get; set; }

        public string AirPortOfDstn { get; set; }

        public string TransShipmentPort { get; set; }

        public string BBAgent { get; set; }

        public string SHPR { get; set; }

        public string CNEE { get; set; }

        public string NTFY { get; set; }
        public string thirtyPTY { get; set; }

        public string finalimport { get; set; }
        public string finalimportAddr { get; set; }

        public string salesperson { get; set; }

        public bool? NoExpect { get; set; }

        public bool? ExportCustoms { get; set; }

        public bool? ImportCustoms { get; set; }

        #region ReadOnly Operation

        public bool pReceiptRead { get; set; }
        public bool pDeptRead { get; set; }
        public bool pDstnRead { get; set; }
        public bool pDEPTPortRead { get; set; }
        public bool pDSTNPortRead { get; set; }
        public bool pDeliveryRead { get; set; }
        //Add By Harry @ 2018/01/14 , for transShipment Readonly setting
        public bool pTransShipmentRead { get; set; }
        public bool bBAgentRead { get; set; }
        public bool termRead { get; set; }
        public bool payTypeRead { get; set; }
        public bool moveRead { get; set; }
        public bool thirdPTRead { get; set; }
        #endregion
        //add by Howard @ 2019/08/07 IsNumberForCustomsClearancePrice
        public bool? IsNumberForCustomsClearancePrice { get; set; }
    }
}
