using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminCommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
