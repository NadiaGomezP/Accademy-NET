using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperasWebSite.Models
{
    public class LoginModel
    {
        //UserName
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        //Password
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //Remember Me
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }
}