using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Data.Items;

namespace Website.Controllers
{
    public class NavigationController : Controller
    {

        public ActionResult Index()
        {
            
            Item currentItem = RenderingContext.Current.ContextItem;
            Item section = currentItem.Axes.GetAncestors()
                    .FirstOrDefault(i => i.TemplateName == "Events Section");
            var model = CreateNavigationMenu(section, currentItem);
            return View(model);
        }
        private NavigationMenu CreateNavigationMenu(Item root, Item current)
        {
            NavigationMenu menu = new NavigationMenu()
            {
                Title = root.DisplayName,
                URL = Sitecore.Links.LinkManager.GetItemUrl(root),
                Children = root.Axes.IsAncestorOf(current) ? root.GetChildren().Select(i => CreateNavigationMenu(i, current)) : null
            };
            return menu;
        }
    }
}