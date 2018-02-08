using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Mvc.Presentation;
using Website.Controllers;

namespace Website.Business
{
    public class ServicesConfigurator : Sitecore.DependencyInjection.IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<EventIntroController>();
            serviceCollection.AddTransient<RenderingContext>(r => RenderingContext.Current);
        }
    }
}