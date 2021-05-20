using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcformvc.Models;

namespace mvcformvc.Controllers
{
    public class mvc_in_mvcController : Controller
    {
        // GET: mvc_in_mvc
        public ActionResult Index()
        {
            var data = GetLogin();
            return View(data);
        }
        private login GetLogin()
        {
            return new login()
            {
                id = 10,
                name = "Dhoni",
                login_id = "Dhoni12@gmail.com",
                password = "Dhoni_mahi"

            };
        }
    }
}