using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NathanSmithPersonalSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutMe()
        {
            return View();
        }

        public ActionResult Resume()
        {
            throw new Exception();
            return View();
        }

        public ActionResult Error404()
        {
            return View();
        }

        public ActionResult Error500()
        {
            return View();
        }
    }
}