﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Areas.Importer.Models
{
    public class Event
    {
        public Event() { }
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
        public string Highlights
        {
            get;
            set;
        }
        public string StartDate
        {
            get;
            set;
        }
        public string Duration
        {
            get;
            set;
        }
        public string Difficulty
        {
            get;
            set;
        }
    }
}