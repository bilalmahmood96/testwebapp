using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using store.Models;

namespace store.Controllers
{
    public class CreateApiTestController : Controller
    {
        // GET: CreateApiTest

        [HttpGet]
        public ActionResult CreateApi()
        {
          
            return View();
        }
     
    }
}