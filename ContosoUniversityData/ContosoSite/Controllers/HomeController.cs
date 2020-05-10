using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// This is the controller class for Home

namespace ContosoSite.Controllers
{
    public class HomeController : Controller
    {
        // called when the index page is launched for the home 
        public ActionResult Index()
        {
            return View();
        }

        // called when the about section is clicked
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // called when the contact section is selected
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}