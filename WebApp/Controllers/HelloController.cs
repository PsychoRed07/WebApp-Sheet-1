using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Semester()
        {
            return View();
        }

        public ActionResult Testimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String name) {

            ViewData["name"] = name;

            return View();

        }
    }
}