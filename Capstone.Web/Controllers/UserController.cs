using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.DAL;
using Capstone.Web.Models;

namespace Capstone.Web.Controllers
{
    public class UserController : PotholeController
    {
        private IUserDAL userDAL;

        public UserController(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Home", "Index");
        }

        [HttpGet]
        [Route("user/register")]
        public ActionResult Register()
        {
            if (base.IsAuthenticated)
            {
                return RedirectToAction("Home", "Index", new { username = base.CurrentUser });
            }
            else
            {
                var model = new RegisterModel();
                return View("Register", model);
            }
        }

        [HttpPost]
        [Route("user/register")]
        public ActionResult Register(RegisterModel newUser)
        {
            if (!ModelState.IsValid)
            {
                return View("Register", newUser);
            }

            userDAL.RegisterUser(newUser);

            return RedirectToAction("Home", "Index");
        }

    }
}