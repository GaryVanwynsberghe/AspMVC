using Roomy.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Utils.Validators
{
    public class ExistingValue : ValidationAttribute
    {
       /* public override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            using (RoomyDbContext db = new RoomyDbContext())
            {
                /*var dbProperties = db.GetType().GetProperties();
                foreach (var item in dbProperties)
                {
                    if (item.PropertyType.FullName.Contains(validationContext.ObjectType.Name)
                    {

                    }
                }

                
            }
            return null;
        }*/
    }
}