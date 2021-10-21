using OnlineCRF_ProjeIT.DAL;
using OnlineCRF_ProjeIT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCRF_ProjeIT.Controllers
{
    public class PersonelController : Controller
    {
       readonly GenericRepository<PersonelListesi> personeller = new GenericRepository<PersonelListesi>();
       
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "deryaozturk")]
        public ActionResult GetPersonel()
        {
            var personel = personeller.List();
            return View(personel);
        }

        [HttpGet]
        public ActionResult UpdateYetki(int id)
        {
            var tablevalue = personeller.Get(x => x.Personel_ID == id);
            return View(tablevalue);
        }

        [HttpPost]
        public ActionResult UpdateYetki(PersonelListesi t)
        {
            personeller.Update(t);
            return RedirectToAction("GetPersonel");
        }
    }
}