using System;
using JobManagementSystem.Common;
using JobManagementSystem.Common.Resources;
using JobManagementSystem.DataModel.Models.CategoryModels;
using JobManagementSystem.Service;
using JobManagementSystem.Web.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace JobManagementSystem.DataModel.Models.AccountModels
{ /// <summary>
    /// Category controller
    /// </summary>
    public class CategoryController : BaseController
    {
        /// <summary>
        /// Reclare category service
        /// </summary>
        private readonly ICategoryService _categoryService;

        /// <summary>
        /// Constructor category controller
        /// </summary>
        /// <param name="categoryService"></param>
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        /// <summary>
        /// Action Get list Categories return view ListCategories
        /// Http get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            var listCategories = _categoryService.GetAllListCategories();
            return View(listCategories);
        }
        
        /// <summary>
        /// Action detail Category return view DetailCategory
        /// GET: Category/Details/5
        /// Htpp get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Details(int? id)
        {
            //check id = null?
            if (id == null)
            {
                return BadRequest();
            }

            var category = _categoryService.GetCategoryById(id);
            
            //Check category = null?
            if (category == null)
            {
                return BadRequest();
            }
            
            return View(category);
        }
        
        /// <summary>
        /// Action create category return view CreateCategory
        /// GET: Category/Create
        /// Http get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Action create category
        /// POST: Category/Create
        /// Http post
        /// </summary>
        /// <param name="categoryViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(CategoryViewModel categoryViewModel)
        {
            if (!ModelState.IsValid) return View(categoryViewModel);
            _categoryService.CreateCategory(categoryViewModel);
            TempData[Constants.CreateSuccess] = MessageResource.CreateSuccess;
            Log.Information(Constants.CreateSuccess);
            return RedirectToAction(nameof(Index));
        }
        /// <summary>
        /// Action Get list update category return view UpdateCategory
        /// Http get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            return View(category);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(int id, CategoryViewModel categoryViewModel)
        {
            if (id != categoryViewModel.Id)
            {
                return BadRequest();
            }
            _categoryService.UpdateCategory(categoryViewModel);
            TempData[Constants.UpdateSuccess] = MessageResource.UpdateSuccess;
            return RedirectToAction(nameof(Index));

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            try
            {
                _categoryService.DeleteCategoryById(id);
                TempData[Constants.DeleteSuccess] = MessageResource.DeleteSuccess;
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData[Constants.DeleteFalse] = MessageResource.DeleteFalse;
                return RedirectToAction(nameof(Index));
            }
            
        }
    }
}