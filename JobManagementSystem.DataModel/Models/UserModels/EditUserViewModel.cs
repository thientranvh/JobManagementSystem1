using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataModel.Models.UserModels
{
    public class EditUserViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public int Role { get; set; }
        public decimal Fund { get; set; }
        public bool Status { get; set; }
    }
}
