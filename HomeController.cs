using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using traditional_routing.Models;

namespace traditional_routing.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult getallstudents()
        {
            return View();
        }

        public ActionResult getstudent(int id)
        {
            return View();
        }

        public ActionResult getallstudentaddress(int id)
        {
            return View();
        }
        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    id = 1,
                    name = "Raj",
                    clas = "Frist",

                    Address = new Address()
                    {
                        stAddress = "this is i address",
                    };
            
                }

            }
        }
    }
}