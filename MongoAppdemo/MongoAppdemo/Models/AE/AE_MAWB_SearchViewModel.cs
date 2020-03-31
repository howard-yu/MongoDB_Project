using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    /// <summary>
    /// Update by Kenny @2018/10/5 add first ETD for AE >> MAWBSearch,VAL-1353(VAL-1355)
    /// </summary>
    public class AE_MAWB_SearchViewModel : SearchResultBase
    {
        public int? MAWBType { get; set; }
        public int? SourceID { get; set; }
        public int? ID { get; set; }
        public string B { get; set; }
        public string MAWBNo { get; set; }
        //public string MawbNoUrl { get; set; }
        public string LotNo { get; set; }
        public string PortOfDSTN { get; set; }
        public string PortOfDEPT { get; set; }
        public string Shipper { get; set; }
        public string CNEE { get; set; }
        public int? PCS { get; set; }
        public int? HNo { get; set; }
        public decimal? GP { get; set; }
        public string eManifestBy { get; set; }
        public DateTime? LasteManifestTime { get; set; }
        public  string PreAlertBy { get; set; }
        public  DateTime? PreAlerDate { get; set; }
        public string ePreAlert { get; set; }
        public string SPINST { get; set; }
        public string Status { get; set; }
        public int StatusID { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM dd yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? IssueDate { get; set; }
        public string IssueDateOrder { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string StationCode { get; set; }
        public string UpdatedBy { get; set; }
        public string Url { get; set; }
        public string CWTUOM { get; set; }
        public string GWTUOM { get; set; }
        public double? CWT { get; set; }
        public double? GWT { get; set; }
        public string WTUOM { get; set; }
        public string AWBType { get; set; }
        public string AWBStatus { get; set; }
        public string AWBMonitorURL { get; set; }
        /// <summary>
        /// Updated By Amanda Lee 2018/08/13 Add UpdatedDate to search page - VAL-1055
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        //Update by Kenny @ 2018/10/5 add ETD for AE >> MAWBSearch
        public DateTime? ETD { get; set; }

        //Update by Amanda @ 2019/7/8 add OnBoardStatus for Search Grid VAL-2478
        public string OnBoardStatus { get; set; }
        public string Trace { get; set; }

    }
}
