using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCMS.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Company Profile";
            return View();
        }
    }
}
