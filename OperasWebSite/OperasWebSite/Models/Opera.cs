using OperasWebSite.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperasWebSite.Models
{
    public class Opera
    {
        public int OperaID { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(200)]
        public string Title { get; set; }

        [CheckValidYear]
        public int Year { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Composer { get; set; }

    }
}