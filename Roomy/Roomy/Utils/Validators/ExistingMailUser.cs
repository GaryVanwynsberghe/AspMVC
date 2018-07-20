using Roomy.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Utils.Validators
{
    public class ExistingMailUser : ValidationAttribute
    {        
        public override bool IsValid(object value)
        {
            using(RoomyGaryDbContext db = new RoomyGaryDbContext())
            {
               return !db.Users.Any(x => x.Mail == value.ToString());
            }
        }
    }
}