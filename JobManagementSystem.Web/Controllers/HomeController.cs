using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobManagementSystem.Web.Models;
using Microsoft.AspNetCore.Authorization;

namespace JobManagementSystem.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //private readonly IAuctionSessionService _auctionSessionService;
        //private readonly IAuctionHistoryCustomerService _historyCustomerService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="auctionSessionService"></param>
        /// <param name="historyCustomerService"></param>
        //public HomeController(IAuctionSessionService auctionSessionService, IAuctionHistoryCustomerService historyCustomerService)
        //{
        //    _auctionSessionService = auctionSessionService;
        //    _historyCustomerService = historyCustomerService;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [AllowAnonymous]
        //public IActionResult Index(string key, int page = 1, int pageSize = 24)
        //{
        //    var listAuction = _auctionSessionService.GetListAuctionSessionApproveActive();
        //    if (!string.IsNullOrEmpty(key))
        //    {
        //        listAuction = listAuction.Where(x => x.Title.ToLower().Contains(key.ToLower()));
        //    }
        //    var listAuctionHot = _auctionSessionService.GetListHotAuction();
        //    ViewBag.listAuctionHot = listAuctionHot;

        //    var listAuctionWait = _auctionSessionService.GetListAuctionSessionWaitActive();
        //    ViewBag.ListAuctionWait = listAuctionWait;

        //    return View(listAuction.OrderBy(x => x.EndBidTime).ToPagedList(page, pageSize));
        //}
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public IActionResult Introduce()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ////[ServiceFilter(typeof(CheckUserIsActiveAttribute))]
        ////public IActionResult History()
        ////{
        ////    varstHistory = _historyCustomerService.GetAllAuctionHistory(userId);
        ////    return V userId = _historyCustomerService.GetUserId();
        ////    var liiew(listHistory);
        ////}
    }
}