using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeaveManagementSystem.Models.Account
{
    public class Register
    {
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }

    }
}