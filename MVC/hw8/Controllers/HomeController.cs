using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hw8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I'm so happy you're here! Connect with me so I can connect with you!";

            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Available from 8AM - 9PM for messaging! I will replay ASAP after receiving your message.";

            return View();
        }

        public ActionResult Employment_History()
        {
            ViewBag.Message = "Your Employment History page here.";

            return View();
        }
    }
}