using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace VoteMovie
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IEnumerable<Movie> Movies = new List<Movie>
        {
            new Movie { Id = 1, Name = "Guardians of the Galaxy" },
            new Movie { Id = 2, Name = "Captain America: The Winter Soldier" },
            new Movie { Id = 3, Name = "Teenage Mutant Ninja Turtles" },
            new Movie { Id = 4, Name = "X-Men: Days of Future Past" },
            new Movie { Id = 5, Name = "A Walk Among the Tombstones" },
            new Movie { Id = 6, Name = "Transformers: Age of Extinction" }
        };

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
