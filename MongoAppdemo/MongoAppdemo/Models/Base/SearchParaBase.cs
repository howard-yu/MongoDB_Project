using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuePlus.ViewModel
{
    /// <summary>
    /// Update by Royal @ 2018/7/2, fix not filter&Sorting in search grid,VP2-771
    /// Update by Royal @ 2018/10/17, Add customer autocomplete for Central Data Source, VAL-1068
    /// </summary>
    public class SearchParaBase : ViewModelBase
    {
        #region Grid Para
        private int _Page = 1;
        public int Page { get { return _Page; } set { _Page = value; } }

        private int _PageSize = 20;
        public int PageSize { get { return _PageSize; } set { _PageSize = value; } }
        #endregion 


        #region Search Script
        public string strSQL { get; set; }
        public string strSQLOrderBy { get; set; }
        #endregion

        #region Search Method
        /// <summary>
        /// Created By Bill @ 2018/07/13 add buildWhereString for Search Grid 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public string buildWhereString(string where = "")
        {
            StringBuilder _build = new StringBuilder();
            if (!string.IsNullOrEmpty(this.strSQL))
                _build.Append(" AND " + this.strSQL + " ");
            else
                _build.Append(" " + where);
            return _build.ToString();
        }
        /// <summary>
        /// Created By Bill @ 2018/07/13 add buildOrderString for Search Grid 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public string buildOrderString(string order = "")
        {
            StringBuilder _build = new StringBuilder();
            if (!string.IsNullOrEmpty(this.strSQLOrderBy))
                _build.Append(" " + this.strSQLOrderBy + " ");
            else
                _build.Append(" " + order);
            return _build.ToString();
        }
        #endregion

        //Add by Royal @ 2018/10/17 set DBSource parameter defalut as Local
        //private DBSource _DBSource = DBSource.Local;
        //public DBSource DBSource { get { return _DBSource; } set { _DBSource = value; } }

        private string _DBSource = "Local";
        public string DBSource { get { return _DBSource; } set { _DBSource = value; } }
    }

    public class SearchResultBase : SearchParaBase
    {
        /// <summary>
        /// Set the Pager Count, due to this is feedback from db
        /// </summary>
        public int Count { get; set; }
    }
}
