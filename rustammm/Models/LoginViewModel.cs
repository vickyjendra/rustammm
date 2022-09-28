using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rustammm.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Username")]
        public string us_usrname { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string us_pwd { get; set; }
    }
}