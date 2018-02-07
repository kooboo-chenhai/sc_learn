using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class EventsList
    {
        public IEnumerable<EventDetails> Events
        {
            get;
            set;
        }
        public int TotalResultCount
        {
            get;
            set;
        }
        public int PageSize
        {
            get;
            set;
        }
    }
}