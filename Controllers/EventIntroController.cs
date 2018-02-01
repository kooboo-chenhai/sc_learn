using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website.Models;
using System.Web.Mvc;
using Sitecore.Web.UI.WebControls;

namespace Website.Controllers
{
    public class EventIntroController : Controller
    {
        public ActionResult Index()
        {
            return View(CreateModel());
        }
        private static EventIntro CreateModel()
        {
            var item = RenderingContext.Current.ContextItem;
            var evetIntro = new EventIntro()
            {
                Heading = new HtmlString(FieldRenderer.Render(item, "ContentHeading")),
                EventImage = new HtmlString(FieldRenderer.Render(item, "Event Image", "mw=400")),
                Highlights = new HtmlString(FieldRenderer.Render(item, "Highlights")),
                Intro = new HtmlString(FieldRenderer.Render(item, "ContentIntro")),
                StartDate = new HtmlString(FieldRenderer.Render(item, "Start Date")),
                Duration = new HtmlString(FieldRenderer.Render(item, "Duration")),
                Difficulty = new HtmlString(FieldRenderer.Render(item, "Difficulty Level"))
            };
            return evetIntro;
        }
    }
}