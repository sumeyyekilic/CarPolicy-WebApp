using AracHasar;
using AracHasar.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AracHasar.Controllers
{
    public class GirisController : Controller
    {
        // GET: Giris
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(AracHasar.data.Kullanıcı kullanıcıModel)
        {
            using (GirisDBEntities6 db = new GirisDBEntities6())
            {
                var kullaniciDetay = db.Kullanıcı.Where(x => x.Kullanıcıİsmi == kullanıcıModel.Kullanıcıİsmi && x.Sifre == kullanıcıModel.Sifre).FirstOrDefault();
                if (kullaniciDetay == null)
                {
                    kullanıcıModel.GirisErrorMessage = "Yanlış kullanıcı adı veya parola.";
                    return View("Index", kullanıcıModel);
                }
                else
                {
                    Session["KullanıcıID"] = kullaniciDetay.KullanıcıID;
                    Session["kullanıcıİsmi"] = kullaniciDetay.Kullanıcıİsmi;
                    return RedirectToAction("Yeni", "Hasar");
                }


            }

        }
        public ActionResult logOut()
        {
            //int kullanıcıID = (int)Session["KullanıcıID"];
            Session.Abandon();
            return RedirectToAction("Index", "Giris");
        }
    }
}