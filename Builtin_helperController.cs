using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Html_Helper1.Controllers
{
    public class Builtin_helperController : Controller
    {
        // GET: Builtin_helper
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }

    }
}