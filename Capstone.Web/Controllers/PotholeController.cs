using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;

namespace Capstone.Web.Controllers
{
    public class PotholeController : Controller
    {
        private const string UsernameKey = "Pothole_UserName";

        private IUserDAL userDAL;

        public PotholeController(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        public bool IsAuthenticated
        {
            get
            {
                return Session["userId"] != null;
            }
        }

        public User CurrentUser
        {
            get
            {
                if (IsAuthenticated)
                {
                    return userDAL.GetUser(Convert.ToInt32(Session["userId"]));
                }

                return null;
            }
        }

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [ChildActionOnly]
        public ActionResult GetNavbar()
        {
            User model = CurrentUser;

            return PartialView("_Navbar", model);
        }

    }
}