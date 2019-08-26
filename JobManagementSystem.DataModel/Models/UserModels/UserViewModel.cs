using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataModel.Models.UserModels
{
    public class UserViewModel
    {
        public int Id { set; get; }
        public string Email { set; get; }
        public string Role { set; get; }
        public string FullName { set; get; }
        public string Gender { set; get; }
        public DateTime BirthDay { set; get; }
        public decimal Fund { set; get; }
        public string Address { set; get; }
        public string PhoneNumber { set; get; }
        public DateTime CreateAt { set; get; }
        public DateTime UpdateAt { set; get; }
        public string CreateBy { set; get; }
        public string UpdateBy { set; get; }
        public bool Status { set; get; }
    }
}
