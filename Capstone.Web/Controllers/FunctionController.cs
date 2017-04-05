using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Web.Controllers
{
    public class FunctionController : Controller
    {
 
        public ActionResult Index()
        {
            return RedirectToAction("Report", "Function");
        }

        [HttpGet]
        public ActionResult Report()
        {
            return View();
        }

    }
}