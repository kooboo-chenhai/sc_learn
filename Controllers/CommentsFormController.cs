using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Sitecore.Mvc.Presentation;
//using TAC.Utils.Mvc;

namespace Website.Controllers
{
    public class CommentsFormController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //[ValidateFormHandler]
        public ActionResult Index(string email, string comment)
        {
            return View("Comfirmation");
        }
    }
}