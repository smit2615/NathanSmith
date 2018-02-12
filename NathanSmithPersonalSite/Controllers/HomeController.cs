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
            ViewBag.Title = "Index";
            return View();
        }

        public ActionResult AboutMe()
        {
            ViewBag.Title = "AboutMe";
            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Title = "Resume";
            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Title = "Projects";
            return View();
        }

        public ActionResult Error404()
        {
            ViewBag.Title = "Error404";
            return View();
        }

        public ActionResult Error500()
        {
            ViewBag.Title = "Error500";
            return View();
        }
    }
}