using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class FeatureEvent
    {
        public  FeatureEvent() {  }
        public HtmlString Heading { get; set; }
        public HtmlString Intro { get; set; }
        public HtmlString EventImage { get; set; }
    }
}