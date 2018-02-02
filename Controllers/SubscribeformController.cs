using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Sitecore.Mvc.Presentation;

namespace Website.Controllers
{
    public class SubscribeformController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string email)
        {
            return View("Comfirmation");
        }
    }
}