using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataAccess.Models
{
    public class Contact : BaseEntity
    {
        public string Title { set; get; }
        public string Content { get; set; }
        public string FeedbackContent { get; set; }
        public string HandlerUserEmail { get; set; }
        public User User { get; set; }
    }
}
