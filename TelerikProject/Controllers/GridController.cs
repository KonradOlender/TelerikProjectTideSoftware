using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikProject.Models;

namespace TelerikProject.Controllers
{
    public class GridController : Controller
    {
        public ActionResult Orders_Read([DataSourceRequest] DataSourceRequest request)
        {
            var result = Enumerable.Range(0, 50).Select(i => new Estate
            {
                Id = i,
                Name = "House" + i * 10,
                Type = i,
                Cost = i,
                Description = "Description"
            });;

            var dsResult = result.ToDataSourceResult(request);
            return Json(dsResult);
        }
    }
}
