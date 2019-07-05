using store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace store.Controllers
{

    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Store()
        {

            return View(DB.myDB);
        }

        public ActionResult Newpage(string ID)
        {

            var obj = DB.myDB.Find(a => a.ID == ID);
            return View(obj);
        }
        public ActionResult Delete(string ID)
        {
            var obj1 = DB.myDB.Find(a => a.ID == ID);
            DB.myDB.Remove(obj1);
            return RedirectToAction("Product");
        }
    }
}

    