using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkwadArabia.ServiceReference1;

namespace AkwadArabia.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Insert()
        {
            return View();
        }

    }
}