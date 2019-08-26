using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataModel.Models
{
    class UsersViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { set; get; }
        public string FullName { set; get; }
        public DateTime BirthDay { set; get; }
        public string PhoneNumber { set; get; }
        public string Address { set; get; }
        public DateTime CreateAt { set; get; }
        public DateTime UpdateAt { set; get; }
        public string CreateBy { set; get; }
        public string UpdateBy { set; get; }
        public bool Status { set; get; }
    }
}
