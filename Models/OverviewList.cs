﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class OverviewList: List<OverviewItem>
    {
        public string ReedMe
        {
            get;
            set;
        }
    }
}