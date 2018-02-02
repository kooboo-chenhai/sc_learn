using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Sitecore.Mvc.Presentation;
namespace Website.Controllers
{
    public class BreadcrumbController: Controller
    { 
        public ActionResult Index()
        {
            return View(CreateModel());
        }

        public IEnumerable<NavigationItem> CreateModel ()
        {
            var currentItem = RenderingContext.Current.ContextItem;
            var homeItem = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);
            var breadcrumb = RenderingContext.Current.ContextItem.Axes.GetAncestors()
                    .Where(i => i.Axes.IsDescendantOf(homeItem))
                    .ToList();
            IEnumerable<NavigationItem> NavigationList = breadcrumb.Select(s => new NavigationItem
            {
                Title = s.DisplayName,
                URL = Sitecore.Links.LinkManager.GetItemUrl(s),
                Active = (s.ID == currentItem.ID)
            });
            return NavigationList;
        }
    }
}