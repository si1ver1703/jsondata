using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO.Pipelines;
using System.Net;
using System.Web.Mvc;
using WebApplication8.Models;
using Controller = System.Web.Mvc.Controller;

namespace WebApplication8.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult GetJsonData()
        {
            return Json(new
            { Id = 1, FirstName = "Jhon", LastName = "Smith", Region = "NY", BirthDate = 1995 / 04 / 23, WorkPlace = "Google NY", Position = "Software Developer" }, new
            { Id = 2, FirstName = "Almat", LastName = "Rakhym", Region = "ALA", BirthDate = 1992 / 12 / 03, WorkPlace = "Prime Source", Position = "Software Tester" }, new
            { Id = 3, FirstName = "Aleksandr", LastName = "Smirnov", Region = "AST", BirthDate = 1996 / 10 / 20, WorkPlace = "Epam KZ", Position = "Back-end Developer" }, new
            { Id = 4, FirstName = "Paul", LastName = "Walker", Region = "FRN", BirthDate = 1999 / 02 / 12, WorkPlace = "Amazon", Position = "Full - Stack Developer" },JsonRequestBehavior.AllowGet);
                }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}