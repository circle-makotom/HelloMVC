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
            // "�_������" ���܂܂�Ă��邱�Ƃ��|�C���g
            ViewBag.Title = "�\n�t�g�E�F�A�Ɋւ��邨�₢���킹";
            ViewBag.Message = "Call me maybe.";

            return View();
        }
    }
}
