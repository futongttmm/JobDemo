using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job.Web.Startup
{
    public class CustomViewEngine : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            // this also feels ugly
            // I could not find another way to detect
            // whether the view name is related to a component
            // but it's somewhat better than adding the path globally


            //if (context.ViewName.StartsWith("Components"))
                return viewLocations.Select(f => f.Replace("/Views/", "/Views/Admin/"));

            //return viewLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context) { }
    }

}
