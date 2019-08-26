using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataModel.Models.CategoryModels
{
    /// <summary>
    /// class for category view model
    /// </summary>
    public class CategoryViewModel : BaseModel
    {
        public string Name { get; set; }
        public DateTime UpdateAt { get; set; }
        public string UpdateBy { get; set; }
        public string StatusString { get; set; }
    }
}
