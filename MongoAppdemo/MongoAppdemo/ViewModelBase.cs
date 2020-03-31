using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace ValuePlus.ViewModel
{
    public class ViewModelBase: IValidatableObject
    {
        //Provide the Current User Info, it will take from API
        private string _CurrentUserID = "";
        public string CurrentUserID { get { return _CurrentUserID; } set { _CurrentUserID = value; } }
        private string _CurrentStationID = "";
        public string CurrentStationID { get {return _CurrentStationID; } set { _CurrentStationID = value; } }

        public IDictionary<string, string> Errors = new Dictionary<string, string>();

        protected IList<ValidationResult> Results = new List<ValidationResult>();

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return Results;
        }

    }
}
