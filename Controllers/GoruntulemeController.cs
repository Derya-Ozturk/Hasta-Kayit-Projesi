using OnlineCRF_ProjeIT.DAL;
using OnlineCRF_ProjeIT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCRF_ProjeIT.Controllers
{
    public class GoruntulemeController : Controller
    {
        readonly GenericRepository<TumTablolar> tablolar = new GenericRepository<TumTablolar>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTables()
        {
            var tables = tablolar.List();
            return View(tables);
        }

        [HttpGet]
        public ActionResult UpdateTables(int id)
        {
            var tablevalue = tablolar.Get(x => x.Hasta_ID == id);
            return View(tablevalue);
        }

        [HttpPost]
        public ActionResult UpdateTables(TumTablolar t)
        {
            tablolar.Update(t);
            return RedirectToAction("GetTables");
        }

        public ActionResult Delete(int id)
        {
            var tablovalue = tablolar.Get(x => x.Hasta_ID == id);
            tablolar.Delete(tablovalue);
            return RedirectToAction("GetTables");
        }
    }
}