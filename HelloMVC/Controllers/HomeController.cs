using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "This is our about page";
            ViewBag.Message = "do diese";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact us";
            ViewBag.Message = "Call me maybe.";

            return View();
        }
    }
}