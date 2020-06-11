using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace TruckerWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.TraceInformation("Requesting the Index page");
            return View();
        }

        public ActionResult About()
        {
            Trace.TraceInformation("Requesting the About page");

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Trace.TraceInformation("Requesting the Contact page");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}