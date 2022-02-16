using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCMS.Controllers
{
    public class NewsCatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
