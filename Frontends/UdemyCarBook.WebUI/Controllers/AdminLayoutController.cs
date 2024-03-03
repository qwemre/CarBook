﻿using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AdminHeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminNavBarPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminSideBarPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminFooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminScriptPartial()
        {
            return PartialView();
        }
    }
}
