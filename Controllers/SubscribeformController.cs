using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Sitecore.Mvc.Presentation;
using TAC.Utils.Mvc;
using Sitecore.Analytics.Outcome.Extensions;
using Sitecore.Analytics.Outcome.Model;
using Sitecore.Analytics.Model.Entities;

namespace Website.Controllers
{
    public class SubscribeformController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateFormHandler]
        public ActionResult Index(string email)
        {
            Sitecore.Analytics.Tracker.Current.Session.Identify(email);
            var contact = Sitecore.Analytics.Tracker.Current.Contact;
            var emails = contact.GetFacet<IContactEmailAddresses>("Emails");
            if (!emails.Entries.Contains("personal"))
            {
                emails.Preferred = "personal";
                var personEmail = emails.Entries.Create("personal");
                personEmail.SmtpAddress = email;
            }

            //var ot = new ContactOutcome(Sitecore.Data.ID.NewID, 
            //                "{D48BAC13-90E9-48AF-9B7C-8C5644E3840D}", 
            //                Sitecore.Analytics.Tracker.Current.Session.Identify(email));
            return View("Comfirmation");
        }
    }
}