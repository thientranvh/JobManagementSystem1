using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using JobManagementSystem.Common;
using JobManagementSystem.Common.Resources;
using JobManagementSystem.DataAccess.Models;
using JobManagementSystem.DataModel.Models.CategoryModels;
using JobManagementSystem.Service.GenericRepository;
using Microsoft.AspNetCore.Http;

namespace JobManagementSystem.Service
{
   /// <summary>
    /// Class category service
    /// </summary>
    public class CategoryService : ICategoryService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IGenericRepository<Category> _genericRepositoryCategory;
        
        private readonly IGenericRepository<User> _genericRepositoryUser;

        private readonly HttpContext _httpContext;
        /// <summary>
        /// 
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor category service
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="httpContext"></param>
        /// <param name="genericRepository"></param>
        /// <param name="genericRepositoryUser"></param>
        public CategoryService(IMapper mapper, IHttpContextAccessor httpContext,IGenericRepository<Category> genericRepository,IGenericRepository<User> genericRepositoryUser)
        {
            _httpContext = httpContext.HttpContext;
            _genericRepositoryCategory = genericRepository;
            _genericRepositoryUser = genericRepositoryUser;
            _mapper = mapper;
        }
        
        /// <summary>
        /// Get all list categories 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CategoryViewModel> GetAllListCategories()
        {
            
            var categories = _genericRepositoryCategory.GetAll().Join(_genericRepositoryUser.GetAll(),
                category => category.CreateBy,
                user => user.Id, (category, user) => new CategoryViewModel
                {
                    Id = category.Id,
                    Name = category.Name,
                    CreateAt = category.CreateAt,
                    CreateByEmail = user.Email,
                    CreateBy = user.Id,
                    UpdateAt = category.UpdateAt,
                    Status = category.Status,
                    UpdateBy = user.Email
                }
            );
            return categories;
        }

        /// <summary>
        /// Get a category by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CategoryViewModel GetCategoryById(int? id)
        {
            var category = _genericRepositoryCategory.GetById(id);
            if (category == null)
            {
                return null;
            }

            var categoryViewModelById = _mapper.Map<CategoryViewModel>(category);
            categoryViewModelById.StatusString = Status(category.Status);
            return categoryViewModelById;
        }
        
        /// <summary>
        /// Create category
        /// </summary>
        /// <param name="model"></param>
        public void CreateCategory(CategoryViewModel model)
        {
            var category = new Category
            {
                Name = model.Name,
                CreateAt = DateTime.UtcNow,
                CreateBy = GetUserId(),
                CreateByEmail = GetUserMail(),
                UpdateBy = GetUserMail(),
                UpdateAt = DateTime.UtcNow,
                Status = true
                
            };
            _genericRepositoryCategory.Create(category);
            _genericRepositoryCategory.Save();
        }

        /// <summary>
        /// Update category
        /// </summary>
        /// <param name="model"></param>
        public void UpdateCategory(CategoryViewModel model)
        {
            var category = _genericRepositoryCategory.GetById(model.Id);
            category.Name = model.Name;
            category.Status = model.Status;
            category.UpdateAt = DateTime.Now;
            category.UpdateBy = _httpContext.User.FindFirst(x => x.Type==Constants.Id).Value;
            _genericRepositoryCategory.Update(category);
            _genericRepositoryCategory.Save();
        }

        /// <summary>
        /// Remove category by id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteCategoryById(int? id)
        {
            _genericRepositoryCategory.Delete(id);
            _genericRepositoryCategory.Save();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        private string Status(bool status)
        {
            return status == false ? CategoryResource.Statusfalse : CategoryResource.StatusTrue;
        }

        /// <summary>
        /// Method GetUserMail return Claim Mail
        /// </summary>
        /// <returns></returns>
        private string GetUserMail()
        {
            return _httpContext.User.FindFirst(x => x.Type == Constants.Email).Value;
        }

        /// <summary>
        /// Method GetUserId return Claim Id
        /// </summary>
        /// <returns></returns>
        private int GetUserId()
        {
            var userId = Convert.ToInt32(_httpContext.User.FindFirst(x => x.Type == Constants.Id).Value);
            return userId;
        }
    }
}    