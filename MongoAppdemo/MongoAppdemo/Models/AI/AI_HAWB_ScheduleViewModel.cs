using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_ScheduleViewModel : ViewModelBase
    {
        ///<summary>
		///SCHCargoTerminalDate
		///</summary>
		public DateTime? SCHCargoTerminalDate { get; set; }

        ///<summary>
        ///SCHReleaseNo
        ///</summary>
        public string SCHReleaseNo { get; set; }

        ///<summary>
        ///SCHReleaseDate
        ///</summary>
        public DateTime? SCHReleaseDate { get; set; }

        ///<summary>
        ///SCHNotifyParty
        ///</summary>
        public int? SCHNotifyParty { get; set; }

        ///<summary>
        ///SCHNotifyPartyCode
        ///</summary>
        public String SCHNotifyPartyCode { get; set; }

        ///<summary>
        ///SCHNotifyDate
        ///</summary>
        public DateTime? SCHNotifyDate { get; set; }

        ///<summary>
        ///SCHDocReleaseParty
        ///</summary>
        public int? SCHDocReleaseParty { get; set; }

        ///<summary>
        ///SCHDocReleasePartyCode
        ///</summary>
        public String SCHDocReleasePartyCode { get; set; }

        ///<summary>
        ///SCHDocReleaseDate
        ///</summary>
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
        public string SCHCargoSignBy { get; set; }

        ///<summary>
        ///SCHLicenseDate
        ///</summary>
        public DateTime? SCHLicenseDate { get; set; }

        ///<summary>
        ///SCHCustomDate
        ///</summary>
        public DateTime? SCHCustomDate { get; set; }

        ///<summary>
        ///SCHDocSignBy
        ///</summary>
        public string SCHDocSignBy { get; set; }

        ///<summary>
        ///SCHCargoReleaseParty
        ///</summary>
        public int? SCHCargoReleaseParty { get; set; }

        ///<summary>
        ///SCHCargoReleasePartyCode
        ///</summary>
        public String SCHCargoReleasePartyCode { get; set; }

        ///<summary>
        ///SCHCargoReleaseDate
        ///</summary>
        public DateTime? SCHCargoReleaseDate { get; set; }

        ///<summary>
        ///SCHCargoReleaseType
        ///</summary>
        public string SCHCargoReleaseType { get; set; }

        public string StationID { get; set; }

        public string StationCode { get; set; }

        public int StationCustomerID { get; set; }

        public List<AI_HAWB_CBViewModel> EntryInfo { get; set; }
    }
}

