using System.Collections.Generic;
using JobManagementSystem.DataModel.Models.CategoryModels;

namespace JobManagementSystem.Service
{
    /// <summary>
    /// Class Category service interface
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// Get all list categories 
        /// </summary>
        /// <returns></returns>
        IEnumerable<CategoryViewModel> GetAllListCategories();
        
        /// <summary>
        /// Get category by int id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CategoryViewModel GetCategoryById(int? id);
        
        /// <summary>
        /// Create new category
        /// </summary>
        /// <param name="model"></param>
        void CreateCategory(CategoryViewModel model);
        
        /// <summary>
        /// Update category
        /// </summary>
        /// <param name="model"></param>
        void UpdateCategory(CategoryViewModel model);
        
        /// <summary>
        /// Delete category by id
        /// </summary>
        /// <param name="id"></param>
        void DeleteCategoryById(int? id);
        
    }
}