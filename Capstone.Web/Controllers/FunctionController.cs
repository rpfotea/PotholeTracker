using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;

namespace Capstone.Web.Controllers
{
    public class FunctionController : PotholeController
    {
        private IPotholeDAL potholeDAL;

        public FunctionController(IPotholeDAL potholeDAL)
        {
            this.potholeDAL = potholeDAL;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Report", "Function");
        }

        [HttpGet]
        public ActionResult Report()
        {
            if (!base.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Report(PotholeModel newPothole)
        {
            int userId = ((User)Session["user"]).UserId;
            DateTime now = DateTime.Now;

            newPothole.WhoReported = userId;
            newPothole.ReportDate = now;

            potholeDAL.ReportPothole(newPothole);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Review()
        {
            if(((User)Session["user"]) == null || ((User)Session["user"]).UserType.ToLower() != "e")
            {
                return RedirectToAction("Index", "Home");
            }

            List<PotholeModel> model = potholeDAL.GetAllPotholes();

            return View("Review", model);
        }

    }
}