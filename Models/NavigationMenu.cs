using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class NavigationMenu: NavigationItem
    {
        public IEnumerable<NavigationMenu> Children
        {
            get;
            set;
        }
    }
}