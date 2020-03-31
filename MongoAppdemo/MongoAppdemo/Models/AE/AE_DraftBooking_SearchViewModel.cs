using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_DraftBooking_SearchViewModel : SearchResultBase
    {
        [Display(Name = "Station ID")]
        public String StationID { get; set; }
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "Type")]
        public String AWBType { get; set; }
        [Display(Name = "Cargo Ava/Date")]
        public DateTime? AvaiDate { get; set; }
        [Display(Name = "Area")]
        public String Area { get; set; }
        [Display(Name = "Service Level")]
        public String ServiceLevel { get; set; }
        [Display(Name = "DSTN")]
        public String PortofDSTN { get; set; }
        [Display(Name = "Book PCS")]
        public int? BKPCS { get; set; }
        [Display(Name = "Book Weight")]
        public decimal? BKGWT { get; set; }

        public double? BKVWT { get; set; }
        public double? VWT { get; set; }
        [Display(Name = "CWT")]
        public double? CWT { get; set; }
        [Display(Name = "Book Volume")]
        public decimal? BKVolume { get; set; }
        [Display(Name = "PCS")]
        public int? WHPCS { get; set; }
        [Display(Name = "Weight")]
        public double? WHGWT { get; set; }

        public double? WHVWT { get; set; }
        [Display(Name = "Volume")]
        public decimal? WHVolume { get; set; }
        [Display(Name = "Dimension")]
        public String WHDimension { get; set; }
        [Display(Name = "Local Name")]
        public String ShipperLocalName { get; set; }
        [Display(Name = "Commodity")]
        public String LocalCommodity { get; set; }
        [Display(Name = "DocType")]
        public String DocType { get; set; }
        [Display(Name = "Master Loader")]
        public String MasterLoader { get; set; }
        [Display(Name = "MAWB#")]
        public String MAWBNo { get; set; }
        [Display(Name = "HAWB#")]
        public String HAWBNo { get; set; }
        [Display(Name = "FLT#")]
        public String FLTNO { get; set; }
        [Display(Name = "Status")]
        public String CSStatus { get; set; }
        [Display(Name = "ETD")]
        public DateTime? ETD { get; set; }
        [Display(Name = "Pullout Date")]
        public DateTime? PulloutDate { get; set; }
        [Display(Name = "Receipt#")]
        public String WHReceiptNo { get; set; }
        [Display(Name = "Terminal")]
        public String Terminal { get; set; }
        [Display(Name = "Arrival Date")]
        public DateTime? WHArrivalDate { get; set; }
        [Display(Name = "C/S")]
        public String CS { get; set; }
        [Display(Name = "Station")]
        public String StationCode { get; set; }
        public String ESTCost { get; set; }
        [Display(Name = "Rate")]
        public String Rate { get; set; }
        [Display(Name = "Hexiaodan#")]
        public String RTHexiaoDanNo { get; set; }
        [Display(Name = "Tuidan Date")]
        public DateTime? RTTuiShuiDate { get; set; }
        [Display(Name = "Remark")]
        public String Remark { get; set; }
        [Display(Name = "Warehouse Remark")]
        public String WHRemark { get; set; }
        [Display(Name = "Book No")]
        public String BKNo { get; set; }

        #region Filter Params
        [Display(Name ="Send?")]
        public String BookSend { get; set; }
        [Display(Name = "Shipment Status")]
        public String Status { get; set; }
        #endregion

        #region Options
        public List<AreaOption> lst_Area { get; set; }
        public struct AreaOption
        {
            public String Area { get; set; }
        }
        public List<ServiceLevelOption> lst_ServiceLevel { get; set; }
        public struct ServiceLevelOption
        {
            public String ServiceLevel { get; set; }
        }
        public List<DocTypeOption> lst_DocType { get; set; }
        public struct DocTypeOption
        {
            public String DocType { get; set; }
        }

        public List<CSStatusOption> lst_CSStatus { get; set; }
        public struct CSStatusOption
        {
            public String CSStatus { get; set; }
        }
        #endregion

        #region Customized params
        public String HAWBUrl { get; set; }
        public String AddHAWBUrl { get; set; }
        public String AddDAWBUrl { get; set; }
        public String CargoDateStr { get; set; }

        bool _DefaultToday = true;
        [Display(Name = "DefaultToday")]
        public bool DefaultToday
        {
            get
            {
                return _DefaultToday;
            }
            set
            {
                _DefaultToday = value;
            }
        }
        #endregion
    }
}