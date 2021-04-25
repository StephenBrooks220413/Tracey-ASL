using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tracey_ASL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "The Home Page.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The About Company Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Courses()
        {
            ViewBag.Message = "Your Course Content page.";

            return View();
        }

        [Authorize]
        public ActionResult Users()
        {
            ViewBag.Message = "Your Profile page.";

            return View();
        }
    }
}