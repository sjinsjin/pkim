using pkimupdate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace pkimupdate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(Registration reg)
        {
            if (ModelState.IsValid)
            {
                WebMail.Send(to: "sjin@pkim.com", subject: "Website Contact information", body: "<br/>Name  : " + reg.Name +
                    "<br/>Phone Number: " + reg.Mobile + "<br/>Email  : " + reg.Email + "<br/>Message: " + reg.Message);
                return RedirectToAction("Email");
            }

            return View();
        }
        public ActionResult Email()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
