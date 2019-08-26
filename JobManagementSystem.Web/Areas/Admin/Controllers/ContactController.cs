using Microsoft.AspNetCore.Mvc;

namespace JobManagementSystem.Web.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}