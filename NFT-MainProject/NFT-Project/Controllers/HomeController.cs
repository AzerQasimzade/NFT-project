﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace NFT_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
    }
}