using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_BookConsole_StationViewModel
    {
        public int ID { get; set; }
        public String ConsoleType { get; set; }
        public String ConsoleStationID { get; set; }
        public String Status { get; set; }
        public String CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public String UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }               
        public String StationID { get; set; }
        public String StationCode { get; set; }

    }
}