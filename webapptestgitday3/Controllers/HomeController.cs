using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapptestgitday3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My web application test GIT.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. message of master 1";

            return View();
        }
    }
}