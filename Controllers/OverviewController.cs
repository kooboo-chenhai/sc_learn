using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;

namespace Website.Controllers
{
    public class OverviewController : Controller
    {
        public ActionResult Index()
        {
            var model = new OverviewList()
            {
                ReedMe = Sitecore.Globalization.Translate.Text("Read More")
            };
            model.AddRange(RenderingContext.Current.ContextItem.GetChildren()
                .Select(i => new OverviewItem()
                {
                    Url = Sitecore.Links.LinkManager.GetItemUrl(i),
                    Title = new HtmlString(FieldRenderer.Render(i, "contentHeading")),
                    Image = new HtmlString(FieldRenderer.Render(i, "decorationbanner", "mw=500&mh=333"))
                }));
            return View(model);
        }
    }
}