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
    //[Route("News")]
    public class NewsController : Controller
    {
        private IHostingEnvironment hostingEnvironment;
        public NewsController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
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
        //[Route("upload")]
        //[HttpPost]
        //public IActionResult Upload(IFormFile upload)
        //{
        //    var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
        //    var path = Path.Combine(Directory.GetCurrentDirectory(), hostingEnvironment.WebRootPath, "img", fileName);
        //    var stream = new FileStream(path, FileMode.Create);
        //    upload.CopyToAsync(stream);
        //    return new JsonResult(new { path = "/img/" + fileName });
        //}
        [HttpPost]
        public async Task<string> uploadImg(IFormFile file)
        {
            string message;
            var saveimg = Path.Combine(hostingEnvironment.WebRootPath, "img", file.FileName);
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
