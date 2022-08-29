using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FA_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Location()
        {
            return View();
        }

        public ActionResult Favorites()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "If you want to know more contact us at 0123456789";

            return View();
        }

        public ActionResult Latest_News()
        {
            ViewBag.Message = "Your contact page.";

            return Redirect("https://screenrant.com/comics/"); ;
        }
    }
}