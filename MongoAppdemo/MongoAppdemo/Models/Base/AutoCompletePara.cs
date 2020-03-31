using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Update by Amy @ 2019/3/6 VP2-835 OMS Appointed Agent Control
namespace ValuePlus.ViewModel
{
    public class AutoCompletePara : ViewModelBase
    {
        public string prefixText { get; set; }
        public string contextKey { get; set; }
        public string prefix { get; set; }
        private int _count = 20;
        public int count { get { return _count; } set { _count = value; } }
        public string PLCode { get; set; }
        //Add by Royal @ 2018/10/17
        public string DBSource { get; set; }
        //add by Amy @ 2019/3/18 VP2-835
        public string ShptStationID { get; set; }
    }
}
