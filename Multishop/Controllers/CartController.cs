﻿using Microsoft.AspNetCore.Mvc;

namespace Multishop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}