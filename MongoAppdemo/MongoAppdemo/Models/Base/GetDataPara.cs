using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel
{
    /// <summary>
    /// Update by Andy Kang @ 2017/12/10,OEHBL Preview 进出口USA,DFS/DIM
    /// Update by Royal @ 2018/7/2, fix not filter&Sorting in search grid,VP2-771
    /// Update by Kenny @ 2018/10/9 VAL-1299(VAL-1285) OE>HBL status is CLOSE,save 3rd Party station
    /// Update by Joyce @ 2018/10/01,add formtype : invoice to get alt.address,VAL-1348
    /// Update by Joyce @ 2019/03/04,VAL-2012,add report name for get summary report url
    /// </summary>

    //Update by Royal @ 2018/7/2, replace ViewModelBase to SearchParaBase
    public class GetDataPara : SearchParaBase
    {
        public int CustomerID { get; set; }

        public int SourceID { get; set; }

        public string Mode { get; set; }

        public string SONo { get; set; }

        public string Type { get; set; }

        public int FormID { get; set; }

        public string BrokerCode { get; set; }

        public string MBLNo { get; set; }

        public string LotNo { get; set; }

        public string CustomerType { get; set; }

        public string ForPrint { get; set; }
        //Update by Andy Kang @ 2017/12/10,OEHBL Preview 进出口USA,DFS/DIM
        public string USAType { get; set; }

        //Updated by Andy Kang @ 2018/01/30,INTTRA
        public int SID { get; set; }//SourceID,避免与Table字段重复所以使用SID
        public int? MID { get; set; }//OEMBLID,避免与Table字段重复所以使用MID
        public string stationID { get; set; }
        //update by Amy @ 2018/6/19  
        public int Origin { get; set; }
        public int DSTN { get; set; }

        //update by Kenny @ 2018/10/9 save 3rd Party station
        public int ThirdParty { get; set; }

        //Update by Joyce @ 2018/10/01,add formtype : invoice to get alt.address
        public string FormType { get; set; }

        //Update by Joyce @ 2019/03/04,add ReportName 
        public string ReportName { get; set; }
    }
}
