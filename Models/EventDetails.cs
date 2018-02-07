using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Web.UI.WebControls;

namespace Website.Models
{
    public class EventDetails : SearchResultItem
    {
        public string ContentHeading
        {
            get;
            set;
        }
        public string ContentIntro
        {
            get;
            set;
        }
        public DateTime StartDate
        {
            get;
            set;
        }
        public HtmlString EventImage
        {
            get {
                return new HtmlString(FieldRenderer.Render(GetItem(), "Event Image", "DisableWebEditing=true&mw=150"));
            }
        }
    }
}