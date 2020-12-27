using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreStudy.Controllers
{
    public class StudyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Java()
        {
            return View();
        }

        public IActionResult CSharp()
        {
            return View();
        }

        public IActionResult Cpp()
        {
            return View();
        }
    }
}
