using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataModel.Models.ContactModels
{
    class ContactViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CreateBy { get; set; }
        public string CreateByEmail { get; set; }
        public string Content { get; set; }
        public string FeedbackContent { get; set; }
        public string HandlerUserEmail { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Status { get; set; }
    }
}
