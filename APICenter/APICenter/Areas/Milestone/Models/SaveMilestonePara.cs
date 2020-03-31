using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICenter.Areas.Milestone.Models
{
    public class SaveMilestonePara
    {
        public string StationID { get; set; }
        public string KeyValue { get; set; }
        public int MileStoneID { get; set; }
        public int MileStoneUnixTime { get; set; }
        public int CreatedUnixTime { get; set; }
        public string CreatedBy { get; set; }
        public string LocalCityCode { get; set; }
        public int ProductlineID { get; set; }
        public string MilestoneCityCode { get; set; }
        public string IrrReason { get; set; }
        public string ApprovedBy { get; set; }
        public string ExtraValue1 { get; set; }
        public string ExtraValue2 { get; set; }
        public int UTCOffSet { get; set; }
        public int? ActiveStatus { get; set; }
        public int HistoryStatus { get; set; }
        public string OldKeyValue { get; set; }
        public string NewKeyValue { get; set; }
        public int NewStatus { get; set; }
        public int OldStatus { get; set; }
        //Update by Howard @20190925
        public string PReceipt { get; set; }

        public string PDEPT { get; set; }

        public string PDSTN { get; set; }

        public string PDelivery { get; set; }
    }
}
