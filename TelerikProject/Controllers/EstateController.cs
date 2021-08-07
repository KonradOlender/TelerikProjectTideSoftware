using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TelerikProject.Data;
using TelerikProject.Models;

namespace TelerikProject.Controllers
{
    public class EstateController : Controller
    {
        private readonly MyContext _context;
        //private readonly IHostingEnvironment _env;

        public EstateController(MyContext context/*, IHostingEnvironment env*/)
        {
            _context = context;
            //_env = env;
        }
        public IActionResult GetAll([DataSourceRequest] DataSourceRequest request)
        {
            var result = _context.estates.ToList();
            var dsResult = result.ToDataSourceResult(request);
            return Json(dsResult);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, int type, float cost, String description)
        {
            Estate e = new Estate();
            e.Name = name;
            e.Type = type;
            e.Cost = cost;
            e.Description = description;
            _context.Add(e);
            _context.SaveChanges();
            return Redirect("~/Home/Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var estate = _context.estates.First(e => e.Id == Id);
            _context.estates.Remove(estate);
            _context.SaveChanges();
            return Redirect("~/Home/Index");
        }

        public IActionResult Update(int id)
        {
            ViewBag.estate = _context.estates.First(e => e.Id == id);
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, string name, int type, float cost, String description)
        {
            var estate = _context.estates.First(e => e.Id == id);
            estate.Name = name;
            estate.Type = type;
            estate.Cost = cost;
            estate.Description = description;
            _context.SaveChanges();
            return Redirect("~/Home/Index");
        }
    }
}
