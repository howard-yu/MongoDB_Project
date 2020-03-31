using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    /// <summary>
    /// Update by Royal @ 2018/8/1 Customs Regulation in Indonesia_HS Code and Tax Number, VAL-1020
    /// Update by Royal @ 2018/8/7 Add CarrierBooking in AEHAWB, VAL-1031
    /// Update by Royal @ 2018/8/20 Add SMAWB Page ,VAL-861
    /// Update by Kenny @ 2018/9/13 VAL-1148 [Value+ 3.0] To test and release e3PS/eCBS/Sales/Cost(VAL-1253)
    /// Update by Amy @ 2019/7/26 VAL-2431 To get POMS URL
    /// </summary>
    [Table("AEHAWB")]
    public class AE_HAWBViewModel : ViewModelBase
    {
        [Key, Column("ID")]
        public int ID { get; set; }

        public int? HAWBID { get; set; }

        public int? MAWBID { get; set; }

        public int? customerID { get; set; }

        public string HAWBNo { get; set; }

        public string StationID { get; set; }

        public int? ParentAWB { get; set; }

        public int? BBAgent { get; set; }

        public string AWBType { get; set; }


        public DateTime? IssueDate { get; set; }

        public string PrintPerson { get; set; }

        public double? DueToAgent { get; set; }

        public double? DueToCarrier { get; set; }

        public double? CUFT { get; set; }

        public bool? CYM { get; set; }

        public bool? NoExpect { get; set; }

        public string PreAlertUser { get; set; }

        public DateTime? PreAlertDate { get; set; }

        public string Status { get; set; }

        public string ServiceLevel { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string SStationID { get; set; }

        public string ShptType { get; set; }

        public string ReferenceCode { get; set; }

        public string SPL { get; set; }

        public string IMPStation { get; set; }

        public string BKNO { get; set; }

        public string ConfirmID { get; set; }

        public string UNCode { get; set; }

        public string MTSNO { get; set; }

        public int? ImportAgent { get; set; }

        public int? SourceID { get; set; }

        public string FRTParty { get; set; }

        public string DBID { get; set; }

        public int? CopyAIID { get; set; }

        public string customerCode { get; set; }
    }
}

