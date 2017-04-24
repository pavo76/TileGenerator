using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TileGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string url, string destination)
        {
            ViewBag.Url = url;
            ViewBag.Destination = destination;
            return View();
        }
        
    }
}