using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminStatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
