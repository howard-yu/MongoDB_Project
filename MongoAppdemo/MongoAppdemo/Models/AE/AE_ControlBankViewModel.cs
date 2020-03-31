using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class RtnBorrowIn : ReturnMSGViewModel
    {
        public List<AE_ControlBankViewModel> data { get; set; }
    }


    public class AE_ControlBankViewModel : SearchResultBase
    {
        ///<summary>
		///AssignedDate
		///</summary>
		public DateTime? AssignedDate { get; set; }

        ///<summary>
        ///BorrowIn
        ///</summary>
        public int? BorrowIn { get; set; }

        ///<summary>
        ///BorrowOutAgent
        ///</summary>
        public int? BorrowOutAgent { get; set; }

        ///<summary>
        ///BorrowOutBy
        ///</summary>
        public string BorrowOutBy { get; set; }

        ///<summary>
        ///BorrowOutDate
        ///</summary>
        public String BorrowOutDate { get; set; }

        ///<summary>
        ///City
        ///</summary>
        public int City { get; set; }

        ///<summary>
        ///ID
        ///</summary>
        public int ID { get; set; }

        ///<summary>
        ///Issuer
        ///</summary>
        public int Issuer { get; set; }

        ///<summary>
        ///LotNo
        ///</summary>
        public string LotNo { get; set; }

        ///<summary>
        ///MAWBNo
        ///</summary>
        public string MAWBNo { get; set; }

        ///<summary>
        ///ReceivedDate
        ///</summary>
        public String ReceivedDate { get; set; }

        ///<summary>
        ///StationID
        ///</summary>
        public string StationID { get; set; }

        ///<summary>
        ///Status
        ///</summary>
        public string Status { get; set; }

        ///<summary>
        ///UsedBy
        ///</summary>
        public string UsedBy { get; set; }

        ///<summary>
        ///UsedDate
        ///</summary>
        public DateTime? UsedDate { get; set; }

        public string AssignedDateStr
        {
            get
            {
                String Descr = "";
                if (this.AssignedDate != null)
                {
                    Descr = this.AssignedDate.Value.ToString("yyyy/MM/dd");
                }
                return Descr;
            }
        }

        public string ReceivedDateStr
        {
            get
            {
                String Descr = "";
                if (this.ReceivedDate != null)
                {
                    Descr = Convert.ToDateTime(this.ReceivedDate).ToString("yyyy/MM/dd");
                }
                return Descr;
            }
        }

        public string BorrowOutDateStr
        {
            get
            {
                String Descr = "";
                if (this.BorrowOutDate != null)
                {
                    Descr = Convert.ToDateTime(this.BorrowOutDate).ToString("yyyy/MM/dd");
                }
                return Descr;
            }
        }

        public string UsedDateStr
        {
            get
            {
                String Descr = "";
                if (this.UsedDate != null)
                {
                    Descr = this.UsedDate.Value.ToString("yyyy/MM/dd");
                }
                return Descr;
            }
        }

        [StringLength(6)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedDateStr
        {
            get
            {
                String Descr = "";
                if (this.CreatedDate != null)
                {
                    Descr = this.CreatedDate.ToString("yyyy/MM/dd");
                }
                return Descr;
            }
        }

        [StringLength(6)]
        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }
        public string UpdatedDateStr
        {
            get
            {
                String Descr = "";
                if (this.UpdatedDate != null)
                {
                    Descr = this.UpdatedDate.ToString("yyyy/MM/dd");
                }
                return Descr;
            }
        }
        public string IssuerCode { get; set; }
        public string IssuerName { get; set; }
        
        public string BorrowInCode { get; set; }
        public string BorrowInName { get; set; }

        public string BorrowOutAgentCode { get; set; }
        public string BorrowOutAgentName { get; set; }

        public string CityCode { get; set; }
        public string CityName { get; set; }

        public Boolean btnReturnVisible { get { setControlBankButton(); return _btnReturnVisible; } }
        public Boolean btnBorrowOutVisible { get { setControlBankButton(); return _btnBorrowOutVisible; } }
        public Boolean btnVoidVisible { get { setControlBankButton(); return _btnVoidVisible; } }

        private Boolean _btnReturnVisible { get; set; }
        private Boolean _btnBorrowOutVisible { get; set; }
        private Boolean _btnVoidVisible { get; set; }

        public string From { get; set; }
        public string To { get; set; }
        public string Prefix { get; set; }

        public string StatusDescr
        {
            get
            {
                String Descr = "";
                if (this.Status != null)
                {
                    switch (this.Status.ToUpper())
                    {
                        case "X":
                            Descr = "Unused";
                            break;
                        case "U":
                            Descr = "Used";
                            break;
                        default:
                            Descr = "Void";
                            break;
                    }
                }
                return Descr;
            }
        }
        

        private void setControlBankButton()
        {
            if (this.Status != null)
            {
                switch (this.Status.ToUpper())
                {
                    case "X":
                        _btnReturnVisible = false;
                        _btnBorrowOutVisible = true;
                        _btnVoidVisible = true;
                        break;
                    case "V":
                        _btnReturnVisible = true;
                        _btnBorrowOutVisible = false;
                        _btnVoidVisible = false;
                        break;
                    default: //case "U"
                        _btnReturnVisible = false;
                        _btnBorrowOutVisible = false;
                        _btnVoidVisible = false;
                        break;
                }
            }

        }


    }

  
}
