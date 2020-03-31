using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel.LocaleChainVP
{
    /// <summary>
    /// Update by Royal @ 2018/8/1 Customs Regulation in Indonesia_HS Code and Tax Number, VAL-1020
    /// Update by Bill @ 2018/08/28 ResourceType is not match Name resource,system error.
    /// </summary>
    public class AE_DAWB_GoodsViewModel 
    {

        public int? BookedPCS { get; set; }

        public string BookedWTUOM { get; set; }

        public double? BookedGWT { get; set; }

        public double? BookedVWT { get; set; }

        public int? ActPCS { get; set; }

        [StringLength(10)]
        public string ActPCSUOM { get; set; }

        public int? SLAC { get; set; }

        [StringLength(5)]
        public string SLACUOM { get; set; }

        [StringLength(5)]

        public string WTUOM { get; set; }

        public double? GWT { get; set; }

        public double? VWT { get; set; }

        public double? CWT { get; set; }

        public string Currency { get; set; }

        public double? SHOW { get; set; }

        public double? SHOWAmount { get; set; }

        //Update by Bill @ 2018/08/28 ResourceType is not match Name resource,system error.
        public double? Sales { get; set; }
        public double? SalesAmount { get; set; }
        public string SalesRateClass { get; set; }

        public double? CTCT { get; set; }
        public double? CTCTAmount { get; set; }
        public string CTCTRateClass { get; set; }

        public double? Comm { get; set; }
        public double? CommAmount { get; set; }
        public bool? ShowRate { get; set; }

        public double? ExComm { get; set; }
        public double? ExCommAmount { get; set; }

     
        public double? NetCostAmount { get; set; }

        public string UNCode { get; set; }
        //update by Royal @ 2018/8/1 add HSCode
        public string HSCode { get; set; }

        //Add by Rou @2019/3/13 , add a reminder maseeage
        public string Description { get; set; }


        public string CommInv { get; set; }


        public string Quantity { get; set; }

        //update by Royal @ 2019/2/19 set interger as nullable
        public int? uiQuantity { get; set; }

        public string Remark { get; set; }

        public string Marks { get; set; }

        public string ExportLIC { get; set; }


    }
}
