using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using qgis2web_downgrade.Models;

namespace qgis2web_downgrade.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("linkform")]
        public IActionResult LinkForm()
        {
            return View();
        }

        [HttpGet("linkpemkot")]
        public IActionResult LinkPemkot()
        {
            return View();
        }

        [HttpGet("news")]
        public IActionResult News()
        {
            return View();
        }

        [HttpGet("webmap")]
        public IActionResult WebMap()
        {
            return View();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}


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
