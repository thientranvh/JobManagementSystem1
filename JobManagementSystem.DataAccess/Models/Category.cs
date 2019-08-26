using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataAccess.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public DateTime UpdateAt { get; set; }
        public string UpdateBy { get; set; }

        public User User { set; get; }
    }
}
