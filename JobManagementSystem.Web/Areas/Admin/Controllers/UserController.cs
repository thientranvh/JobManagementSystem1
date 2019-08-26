using Microsoft.AspNetCore.Mvc;

namespace JobManagementSystem.Web.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}