using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Data.Fields;

namespace Website.Controllers
{
    public class RelatedEventsController : Controller
    {

        public ActionResult Index()
        {
            var item = RenderingContext.Current.Rendering.Item;
            if (item == null) return new EmptyResult();
            MultilistField relatedEvents = item.Fields["Related Events"];
            if (relatedEvents == null) return new EmptyResult();
            var events = relatedEvents.GetItems()
                .Select(i => new NavigationItem()
                {
                    Title = i.DisplayName,
                    URL = Sitecore.Links.LinkManager.GetItemUrl(i)
                });
            return View(events);
        }
    }
}