using OnlineCRF_ProjeIT.DAL;
using OnlineCRF_ProjeIT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCRF_ProjeIT.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddToTables()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddToTables(TumTablolar t)
        {
            GenericRepository<TumTablolar> tablolar = new GenericRepository<TumTablolar>();
            tablolar.Insert(t);
            return View("Index");
        }

    }
}