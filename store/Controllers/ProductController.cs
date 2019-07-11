using Newtonsoft.Json;
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
        [HttpGet]
        public ActionResult Store()
        {

            return View(DB.myDB);
        }

        public ActionResult Newpage(string ID)
        {
            var obj = DB.myDB.Find(a => a.ID == ID);
            return View(obj);
        }
        //public ActionResult Newpage(string ID)
        //{
        //    var obj1 = DB.myDB.Find(a => a.ID == ID);
        //    DB.myDB.Remove(obj1);
        //    return View();
        //}
        [HttpPost]
        public ActionResult Edit(dataclass db)
        {
            var obj = DB.myDB.FindIndex(a => a.ID == db.ID);
            DB.myDB[obj] = db;
            Sync();
            return RedirectToAction("Store");
        }
        [HttpGet]
        public ActionResult Create() {
            return View(new dataclass());

        }
        [HttpPost]
        public ActionResult Create(dataclass db)
        {
            DB.myDB.Add(db);
            Sync();
            return RedirectToAction("Store");
        }

        [HttpGet]
        public ActionResult Edit(string ID)
        {
            var obj = DB.myDB.Find(a => a.ID == ID);
            return View(obj);
        }

        public void Sync() {

         var text  = JsonConvert.SerializeObject(DB.myDB);
            string textFile = Server.MapPath("/Models/data.json");
            System.IO.File.WriteAllText(textFile, text);


        }
        //[HttpPost]
        public ActionResult DeleteItem(string ID)
        {
            var obj = DB.myDB.Find(a => a.ID == ID);
            DB.myDB.Remove(obj);
            Sync();
            return RedirectToAction("Store");
        }
    }

}

    