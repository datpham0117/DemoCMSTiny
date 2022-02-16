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
        public static IWebHostEnvironment environment;
        public NewsController(IWebHostEnvironment env)
        {
            environment = env;
        }
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
        [HttpPost]
        public async Task<string> uploadImg(IFormFile file)
        {
            string message;
            var saveimg = Path.Combine(environment.WebRootPath, "img", file.FileName);
            string imgext = Path.GetExtension(file.FileName);

            if (imgext == ".jpg" || imgext == ".png")
            {
                using (var uploadimg = new FileStream(saveimg, FileMode.Create))
                {

                    await file.CopyToAsync(uploadimg);
                    message = "The selected file" + file.FileName + " is save";
                }

            }
            else
            {
                message = "only JPG and PNG extensions are supported";
            }
            return "filename : " + saveimg + " message :" + message;
        }
    }
}
