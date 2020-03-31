using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel
{

    public class ReturnMSGViewModel: ViewModelBase
    {
        private int _errorCode = 0;
        public int errorCode { get { return _errorCode; } set { _errorCode = value; } }
        public bool IsSuccess { get { return (_errorCode == 0); } }

        private string _errorMSG = "";
        public string errorMessage
        {
            get
            {
                return _errorMSG;
            }
            set
            {
                _errorMSG = value;
            }
        }

        public object returnValue { get; set; }
        public List<string> returnValueList { get; set; }
        public List<string> wrongItemCodeList { get; set; }
        public List<string> completeItemCodeList { get; set; }

        public List<overItemCode> overItemCodeList { get; set; }
    }
    public class overItemCode
    {
        public string ItemCode { get; set; }
        public int Count { get; set; }
    }
}
