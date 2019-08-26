using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataAccess.Models
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public bool Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime UpdateAt { get; set; }

        public List<Category> Categories { set; get; }
        public List<Contact> Contacts { get; set; }
    }
}
