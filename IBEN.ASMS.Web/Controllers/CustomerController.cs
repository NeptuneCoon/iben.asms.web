﻿using Microsoft.AspNetCore.Mvc;

namespace IBEN.ASMS.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
