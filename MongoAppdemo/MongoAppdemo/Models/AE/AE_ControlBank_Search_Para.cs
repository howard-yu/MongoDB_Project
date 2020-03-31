using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{    
    public class AE_ControlBank_Search_Para : SearchParaBase
    {
        public string NumberType { get; set; }

        public string Number { get; set; }

        public string DateType { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string StatusDescr { get; set; }

        public int BorrowInBy { get; set; }
    }
}
