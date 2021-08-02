using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperasWebSite.Validation
{
    public class CheckValidYear: ValidationAttribute
    {
        public CheckValidYear()
        {
            ErrorMessage = "Fecha Invalidad";

        }

        public override bool IsValid(object value)
        {
            DateTime Fecha = (int) value;

            if (year < 1598)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}