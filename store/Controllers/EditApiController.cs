using Newtonsoft.Json;
using store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace store.Controllers
{
    public class EditApiController : Controller
    {
        // GET: EditApi
        [HttpGet]
        public ActionResult EditView(string ID)
        {
            dataclass temp = new dataclass() { ID = ID };
            return View(temp);
        }       
    }
}