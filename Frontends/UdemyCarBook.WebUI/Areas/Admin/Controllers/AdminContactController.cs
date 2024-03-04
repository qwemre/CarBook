using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
