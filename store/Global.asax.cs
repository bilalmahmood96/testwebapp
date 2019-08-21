using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Newtonsoft.Json;
using store.Models;

namespace store
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            string textFile = Server.MapPath("/Models/autoIDdata.json");
            if (File.Exists(textFile))
            {
                // Read entire text file content in one string  
                string text = File.ReadAllText(textFile);
                DB.myDB = JsonConvert.DeserializeObject<List<dataclass>>(text);
            }
        
        }
    }
}
