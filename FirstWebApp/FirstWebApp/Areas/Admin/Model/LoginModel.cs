using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstWebApp.Areas.Admin.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter user name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}