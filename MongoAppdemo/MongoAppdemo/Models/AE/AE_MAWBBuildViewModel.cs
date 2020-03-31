using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    //在打开BuildConsole时返回的内容，或者在saveBuild Console时用到
    
    public class AE_MAWBBuildViewModel : ViewModelBase
    {

        //save
        public int MAWBID { get; set; }

        //load
        public string Lotno { get; set; }
        //load
        public string MAWBNo { get; set; }
        //load
        public int DSTNID { get; set; }
        //load
        public string DSTNCode { get; set; }

        //需要增加的HAWBID
        //Save
        public string addedItem { get; set; }

        //需要Remove的HAWBID
        //Save
        public string removeItem { get; set; }

        public int CNEEID { get; set; }

    }
}

