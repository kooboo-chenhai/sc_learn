using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Areas.Importer.Controllers
{
    public class EventsController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFile file, string parentPath)
        {
            //IEnumerable<Event> events = null;
            //string message = null;
            //using (var reader = new System.IO.StreamReader(file.InputStream))
            //{
            //    var contents = reader.ReadToEnd();
            //    try
            //    {
            //        events = JsonConvert
            //    }
            //}
                return View();
        }
    }
}