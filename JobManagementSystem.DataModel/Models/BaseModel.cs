using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataModel.Models
{
    public class BaseModel
    {
        public int Id { set; get; }
        public DateTime CreateAt { set; get; }
        public int CreateBy { set; get; }
        public string CreateByEmail { set; get; }
        public bool Status { set; get; }
    }
}
