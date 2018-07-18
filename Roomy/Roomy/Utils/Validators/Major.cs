using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Utils.Validators
{
    public class Major : ValidationAttribute
    {
        private int years;

        public Major(int years)
        {
            this.years = years;
        }

        public override bool IsValid(object value)
        {
            if (value is DateTime)
            {
                var dt = (DateTime)value;
                return dt.AddYears(this.years) <= DateTime.Now;
            }
            return false;            
        }
    }
}