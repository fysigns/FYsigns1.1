using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignFix.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        // add views and view access based on roles 
        [HttpGet]
        public ActionResult SignOrderForm()
        {
            ViewBag.Message = "Order Sign Page";

            return View();
        }

        public ActionResult PlaceOrder()
        {
            ViewBag.Message = "Place landing  order page";

            return View();
        }

        [HttpGet]
        public ActionResult NewSignPlacementform()
        {
            ViewBag.Message = " Placde New Sign";

            return View();
        }
        //[HttpGet]
        //public ViewResult RsvpForm()
        //{
        //    return View();
        //}
    }
}