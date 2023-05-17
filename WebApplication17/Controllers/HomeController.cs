using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication17.Models;
using WebApplication17.Models.Interface;
using WebApplication17.Models.ShapeModel.BaseShape;
using WebApplication17.Models.ShapeModel.UnderShape;

namespace WebApplication17.Controllers
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
            List<ShapeDicorator> model = new List<ShapeDicorator>() { new ShapeDicorator(new Circle(), "red", "blue"), new ShapeDicorator(new Triangle(), "green", "blue") };
           
            return View("Index" , model);
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
