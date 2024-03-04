using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminLocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
