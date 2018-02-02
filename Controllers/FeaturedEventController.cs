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
    public class FeaturedEventController : Controller
    {
        public ActionResult Index()
        {
            return View(CreateModel());
        }

        private static FeaturedEvent CreateModel()
        {
            var item = RenderingContext.Current.Rendering.Item;
            var featuredEvent = new FeaturedEvent()
            {
                Heading = new HtmlString(FieldRenderer.Render(item, "ContentHeading")),
                EventImage = new HtmlString(FieldRenderer.Render(item, "ContentHeading")),
                Intro = new HtmlString(FieldRenderer.Render(item, "ContentIntro"))
            };
            return featuredEvent;
        }
    }
}