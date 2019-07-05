using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace store.Controllers
{
    public class NewpageController : Controller
    {
        // GET: Newpage
        public ActionResult Index()
        {
            return View();
        }
    }
}