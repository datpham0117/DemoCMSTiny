using DemoCMS.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCMS.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            List<NewsViewModel> model = new List<NewsViewModel>()
            {
                new NewsViewModel { ID = 1, Number = "News1", Name = "News1", Description = "News1 is description" },
                new NewsViewModel { ID = 2, Number = "News2", Name = "News2", Description = "News2 is description" },
            };
            return View(model);
        }
        public IActionResult AddNews()
        {
            NewsViewModel model = new NewsViewModel();
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit()
        {
            NewsViewModel model = new NewsViewModel { ID = 1, Number = "News1", Name = "News1", Description = "News1 is description", NewsContent = "News1 is NewsContent" };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(NewsViewModel model)
        {
            model = new NewsViewModel { ID = 1, Number = "News1", Name = "News1", Description = "News1 is description", NewsContent = "News1 is NewsContent" };
            return View(model);
        }
    }
}
