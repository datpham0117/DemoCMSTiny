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
    //[Route("NewsCkEditor")]
    public class NewsCkEditorController : Controller
    {
        private IHostingEnvironment hostingEnvironment;
        public NewsCkEditorController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        //[Route("index")]
        //[Route("")]
        //[Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("img")]
        [HttpPost]
        public IActionResult UploadCKEditor(IFormFile upload)
        {
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), hostingEnvironment.WebRootPath,"img", fileName);
            var stream = new FileStream(path, FileMode.Create);
            upload.CopyToAsync(stream);
            return new JsonResult(new { path = "/img/" + fileName});
        }
    }
}
