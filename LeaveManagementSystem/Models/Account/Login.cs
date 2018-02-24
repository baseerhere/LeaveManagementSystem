using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeaveManagementSystem.Models.Account
{
    public class Login
    {
        [Required(ErrorMessage = "Email Id Required", AllowEmptyStrings = false)]
        [DisplayName("Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
                                    ErrorMessage = "Email Format is wrong")]
        public string EmailAddress { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Required", AllowEmptyStrings = false)]
        public string Password { get; set; }
        public string Role { get; set; }
        public bool RememberMe { get; set; }


    }
}