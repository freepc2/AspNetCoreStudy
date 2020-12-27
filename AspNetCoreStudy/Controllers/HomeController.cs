using AspNetCoreStudy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreStudy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        ///  http://www.example.com/Home/Index
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///  http://www.example.com/Home/Privacy
        /// </summary>
        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        ///  http://www.example.com/Home/Error
        /// </summary>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
