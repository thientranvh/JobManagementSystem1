using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JobManagementSystem.Common;
using JobManagementSystem.Common.Infrastructure;
using JobManagementSystem.Common.Resources;
using JobManagementSystem.DataModel.Models.AccountModels;
using JobManagementSystem.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace JobManagementSystem.Web.Controllers
{
    public class AccountController : Controller
    {
        //Define accountService
        private readonly IAccountService _accountService;

        //Initial value for accountService
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET
        /// <summary>
        /// Action Authentication Get return View Authentication
        /// </summary>
        /// <param name="requestPath"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Authentication(string requestPath)
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Response.Cookies.Delete(CookieAuthenticationDefaults.AuthenticationScheme);
            //Transmission ViewBag to View
            try
            {
                ViewBag.RequestPath = requestPath ?? Signs.Slash;
                return View();
            }
            catch (Exception e)
            {
                Log.Error(e, AccountResource.ControllerAuthenticationError);
                return BadRequest();
            }
        }

        /// <summary>
        /// Action Authentication Post Verify Authentication. If Authen success redirect to requestPath
        /// else return View with accountLoginModel
        /// </summary>
        /// <param name="accountLoginModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Authentication(AccountLoginModel accountLoginModel)
        {
            //Check ModelState if false return View with loginModel
            if (!ModelState.IsValid) return View(accountLoginModel);

            try
            {
                //Get account
                var account = _accountService.Authentication(accountLoginModel);

                //Check null account,if not null add Cookie Authentication
                if (account == null)
                {
                    ModelState.AddModelError(Signs.DoubleQuotationMarks, AccountResource.AuthenticaltionFailed);
                    return View(accountLoginModel);
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, account.Id.ToString()),
                    new Claim(Constants.Id, account.Id.ToString()),
                    new Claim(Constants.Email, account.Email),
                    new Claim(ClaimTypes.Role, account.Role == 1 ? nameof(RoleEnum.Admin) : nameof(RoleEnum.Member))
                };

                // create identity
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                // create principal
                var principal = new ClaimsPrincipal(identity);

                // sign-in
                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal,
                    new AuthenticationProperties());

                return Redirect(accountLoginModel.RedirectUrl ?? Signs.Slash);
            }
            catch (Exception e)
            {
                Log.Error(e, AccountResource.ErrorAuthentication);
                return BadRequest();
            }
        }

        /// <summary>
        /// Action Logout delete authentication cookie
        /// </summary>
        /// <returns>Redirect to View Login and delete Cookie Authentication</returns>
        public IActionResult Logout()
        {
            try
            {
                //Logout with SignOutAsync
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.Response.Cookies.Delete(CookieAuthenticationDefaults.AuthenticationScheme);

                return RedirectToAction(ActionNames.Authentication, ControllerNames.Account);
            }
            catch (Exception e)
            {
                Log.Error(e, AccountResource.LogoutError);
                return BadRequest();
            }
        }

        /// <summary>
        /// Action Register GET, return View Register
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Register()
        {
            Logout();
            try
            {
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Action Register POST, if success add 1 User to Db
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(RegisterUserModel registerModel)
        {
            try
            {
                if (!ModelState.IsValid) return View(registerModel);
                var userRegister = _accountService.RegisterUserModel(registerModel);

                if (userRegister == null)
                {
                    ModelState.AddModelError(Signs.DoubleQuotationMarks, AccountResource.AccountExisted);
                    return View(registerModel);
                }
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, userRegister.Id.ToString()),
                    new Claim(Constants.Id, userRegister.Id.ToString()),
                    new Claim(Constants.Email, userRegister.Email),
                    new Claim(ClaimTypes.Role, userRegister.Role == 1 ? nameof(RoleEnum.Admin) : nameof(RoleEnum.Member))
                };

                // create identity
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                // create principal
                var principal = new ClaimsPrincipal(identity);

                // sign-in
                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal,
                    new AuthenticationProperties());

                return RedirectToAction(ActionNames.Index, ControllerNames.Home);
            }
            catch (Exception e)
            {
                Log.Error(e, AccountResource.RegisterControllerLogError);
                return BadRequest();
            }
        }
    }
}