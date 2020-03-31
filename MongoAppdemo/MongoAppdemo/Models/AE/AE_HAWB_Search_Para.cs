using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_HAWB_Search_Para : SearchParaBase
    {
        public String HAWBNo { get; set; }
        public String MAWBNo { get; set; }
        public String SHPR { get; set; }
        public String CNEE { get; set; }
        public String NTFY { get; set; }
        public String PDischarge { get; set; }
        public String LotNo { get; set; }
        public String CTNRNo { get; set; }
        public String POD { get; set; }
        public String SONo { get; set; }
        public String Vessel { get; set; }
        public String Voyage { get; set; }
        public String Carrier { get; set; }
        public String BookingNo { get; set; }
        public String POL { get; set; }
        public String POLETDF { get; set; }
        public String POLETDT { get; set; }
        public String StationID { get; set; }
        public String PONo { get; set; }
        public String Status { get; set; }
        public String View { get; set; }
        public String UserName { get; set; }
        public String Orderby { get; set; }
        public String ByDesc { get; set; }
        public String PReceipt { get; set; }
        public String PDelivery { get; set; }
        public String SalesPerson { get; set; }
        public String AMSStatus { get; set; }
        public String ISFAStatus { get; set; }
        public String Customer { get; set; }
        public String CustomerName { get; set; }
        public String SHPRName { get; set; }
        public String CNEEName { get; set; }
        public String MTSNO { get; set; }
        public String BookingStatus { get; set; }
        public String WSAssignTo { get; set; }
        public String MyWS { get; set; }
        public String UserID { get; set; }
        public String tradeTerm { get; set; }
        /// <summary>
        /// Update by Amanda Lee 2018/08/02 to include DNNo as Search_Para - VAL-1030
        /// </summary>
        public String DNNo { get; set; }
        /// <summary>
        /// updated by Amanda Lee 2018/08/10 add CreatedBy CreatedDate UpdatedBy UpdatedDate - VAL-1055
        /// </summary>
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }
        public String CreatedDate { get; set; }
        public String UpdatedDate { get; set; }
    }
}
