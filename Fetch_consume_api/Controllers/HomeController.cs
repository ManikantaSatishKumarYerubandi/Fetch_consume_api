﻿using Fetch_consume_api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fetch_consume_api.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult PostData()
        {
            return View();
        }
        public IActionResult User()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}