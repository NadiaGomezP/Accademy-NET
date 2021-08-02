using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebVuelos.Validation
{
    public class CheckValidYear : ValidationAttribute
    {
        public CheckValidYear()
        {
            ErrorMessage = "Fecha invalida";

        }

        public override bool IsValid(object value)
        {
            return DateTime.Compare(DateTime.Now, Convert.ToDateTime(value)) < 0;
        }
    }
}