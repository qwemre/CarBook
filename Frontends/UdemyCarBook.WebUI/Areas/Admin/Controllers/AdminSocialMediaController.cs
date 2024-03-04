using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminSocialMediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
