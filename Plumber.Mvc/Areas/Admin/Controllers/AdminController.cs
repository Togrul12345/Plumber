﻿using Microsoft.AspNetCore.Mvc;

namespace Plumber.Mvc.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
