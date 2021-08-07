using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikProject.Data;
using TelerikProject.Models;

namespace TelerikProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IActionResult Index()
        {
            List<Estate> houses = _context.estates.Where(e => e.Type == 0).ToList();
            var flats = _context.estates.Where(e => e.Type == 1).ToList();
            ViewBag.flats = flats;
            ViewBag.houses = houses;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
