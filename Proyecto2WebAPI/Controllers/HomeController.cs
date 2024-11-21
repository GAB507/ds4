using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto2WebAPI.Controllers
{
    public class HomeController : Controller
    {
        [System.Web.Http.HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
 

    }
}
