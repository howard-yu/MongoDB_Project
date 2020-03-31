using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel
{
    public class DDLViewModel : ViewModelBase
    {
        public int eID
        {
            get; set;
        }
        public string eCode { get; set; }
        public string eName { get; set; }
    }
}
