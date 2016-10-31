using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commrece.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Datetime = DateTime.Now.ToUniversalTime();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}