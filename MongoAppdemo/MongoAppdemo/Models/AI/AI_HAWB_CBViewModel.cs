using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    public class AI_HAWB_CBViewModel : ViewModelBase
    {
        ///<summary>
        ///FLTNo
        ///</summary>
        public string FLTNo { get; set; }

        ///<summary>
        ///EntryPort
        ///</summary>
        public string EntryPort { get; set; }

        ///<summary>
        ///LandingDate
        ///</summary>
        public DateTime? LandingDate { get; set; }

        ///<summary>
        ///PCS
        ///</summary>
        public string PCS { get; set; }

        ///<summary>
        ///CWT
        ///</summary>
        public string CWT { get; set; }

        ///<summary>
        ///ITNo
        ///</summary>
        public string ITNo { get; set; }

        ///<summary>
        ///Storage
        ///</summary>
        public string Storage { get; set; }
    }
}

