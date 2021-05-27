using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Html_Helper1.Models;

namespace Html_Helper1.Controllers
{
    public class stronglyController : Controller
    {
        // GET: strongly
        public ActionResult Index()
        {
            strongly str = new strongly()
            {
                name = "raj",
                address ="Sihor",
                isemployee =true

            };
            return View(str);
        }
        [HttpPost]
        public ActionResult index(strongly str)
        {
            return View();
        }
    }
}