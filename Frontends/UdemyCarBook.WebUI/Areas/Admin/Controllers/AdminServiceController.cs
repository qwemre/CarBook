using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
