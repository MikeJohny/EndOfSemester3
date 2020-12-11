using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EndOfSemester3.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Auction()
        {
            ViewBag.Message = "Welcome to AuctionSite!";
            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }


    }
}
