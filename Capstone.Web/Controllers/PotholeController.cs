using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Web.Controllers
{
    public class PotholeController : Controller
    {
        private const string UsernameKey = "Pothole_UserName";

        // GET: Pothole
        public ActionResult Index()
        {
            return View();
        }

        public bool IsAuthenticated
        {
            get
            {
                return Session[UsernameKey] != null;
            }
        }


        /// <summary>
        /// Gets the value from the Session
        /// </summary>
        public string CurrentUser
        {
            get
            {
                string username = string.Empty;

                //Check to see if user cookie exists, if not create it
                if (Session[UsernameKey] != null)
                {
                    username = (string)Session[UsernameKey];
                }

                return username;
            }
        }


    }
}