using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add by Amy @ 2019/3/18 VP2-835 For OMS Appointed Agent Control
namespace ValuePlus.ViewModel
{
    public class CustomerLookupPara : ViewModelBase
    {
        public string PL { get; set; }
        public string SearchBy { get; set; }

        public string CustID { get; set; }
        public string CustCode { get; set; }
        public string CustName { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        //add by Amy @ 2019/3/18 VP2-835
        public string ShptStationID { get; set; }
    }
}
