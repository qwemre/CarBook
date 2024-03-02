using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.CommentViewComponents
{
    public class _CommentListByBlogComponentPartail : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
