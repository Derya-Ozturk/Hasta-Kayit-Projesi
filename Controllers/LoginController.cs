using OnlineCRF_ProjeIT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineCRF_ProjeIT.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(GirisSayfasi p)
        {
            ProjeIT_DBContext c = new ProjeIT_DBContext();
            var userinfo = c.GirisSayfasi.FirstOrDefault(x => x.Kullanici_Adi == p.Kullanici_Adi && x.Sifre == p.Sifre);
            if(userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.Kullanici_Adi, false);
                Session["Kullanici_Adi"] = userinfo.Kullanici_Adi;
                return RedirectToAction("Index", "Default");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
    }
}