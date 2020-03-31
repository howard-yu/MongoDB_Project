using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_APPHAWBNoViewModel : SearchResultBase
    {
        ///<summary>
        ///HAWBNo
        ///</summary>
        public string HAWBNo { get; set; }

        ///<summary>
        ///ID
        ///</summary>
        ///<remarks>Identity Specification Is Identity</remarks>
        public int ID { get; set; }

        ///<summary>
        ///StationID
        ///</summary>
        public string StationID { get; set; }

        ///<summary>
        ///Status
        ///</summary>
        public string Status { get; set; }

        ///<summary>
        ///CreatedBy
        ///</summary>
        public string CreatedBy { get; set; }

        ///<summary>
        ///CreatedDate
        ///</summary>
        public DateTime CreatedDate { get; set; }

        ///<summary>
        ///UpdatedBy
        ///</summary>
        public string UpdatedBy { get; set; }

        ///<summary>
        ///UpdatedDate
        ///</summary>
        public DateTime? UpdatedDate { get; set; }

        ///<summary>
        ///Version
        ///</summary>
        public byte[] Version { get; set; }

        public string customerCode { get; set; }

        public int? customerID { get; set; }
    }
}
