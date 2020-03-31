using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AE_BookConfigViewModel
    {
        public int ID { get; set; }
        public String ConfigType { get; set; }
        public String ConfigValue { get; set; }
        public String ConfigLocalValue { get; set; }
        public String Status { get; set; }
        public String CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public String UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
