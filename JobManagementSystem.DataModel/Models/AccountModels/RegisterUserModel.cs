using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobManagementSystem.DataModel.Models.AccountModels
{
    public class RegisterUserModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
