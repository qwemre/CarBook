using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminPricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
