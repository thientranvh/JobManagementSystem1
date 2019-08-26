using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobManagementSystem.Common;
using JobManagementSystem.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobManagementSystem.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = Constants.Admin)]
    public class HomeController : BaseController
    {
        private readonly IDashboardService _dashboardSevice;

        //public HomeController(IDashboardSevice dashboardSevice)
        //{
        //    _dashboardSevice = dashboardSevice;
        //}
        /// <summary>
        /// Action Index return View Index
        /// </summary>
        /// <returns></returns>
        //Get
        //[HttpGet]
        public IActionResult Index()
        {
            //var listjob = _dashboardSevice.GetActivedJob();
            //var listLabels = listjob.Select(item => item.Date.ToLongDateString().ToString()).ToList();
            //ViewBag.ListLabel = listLabels;

            //var listData = listjob.Select(item => item.Total);
            //ViewBag.ListData = listData;
            //return View(listjob);
            return View();
        }
    }
}
