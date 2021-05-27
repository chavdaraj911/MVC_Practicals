using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Html_Helper1.Models;

namespace Html_Helper1.Controllers
{
    public class templateController : Controller
    {
        // GET: template
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                id = 1,
                Name = "raj",
                email = "raj@gmail.com",
                dateofbirth = DateTime.Now,
                isonline = true
            };
            return View(emp);
        }
        public ActionResult edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult edit(Employee emp)
        {
            return View();
        }
    }
}