using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerBouquet.Controllers
{
    public class staticController : Controller
    {
        // GET: static
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Team ()
        {
            return View();
        }
    }
}