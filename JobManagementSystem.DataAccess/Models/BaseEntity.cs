using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataAccess.Models
{
    public class BaseEntity
    {
        public int Id { set; get; }
        public DateTime CreateAt { set; get; }
        public string CreateByEmail { set; get; }
        public int CreateBy { set; get; }
        public bool Status { set; get; }
    }
}
