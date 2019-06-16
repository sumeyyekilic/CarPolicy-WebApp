using AracHasar.data;
using AracHasar.Models.Hasar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AracHasar.Controllers
{
    public class HasarController : Controller
    {
        // GET: Hasar
        
        // GET: Hasar
        public ActionResult Ekle()
        {
            return View();
        }
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(AracHasarBilgisi model)
        {
            return View(new Create().Add(model));
        }
        public ActionResult Liste()
        {
            return View(new List().GetAll());
        }
        public ActionResult Sil(int? id)
        {
            if ((new Delete().DeleteState(id))) //delete sınıfından deletestate'i tutup bunu if içerisinde karar ver
            {
                return RedirectToAction("Liste", "Hasar"); //true ise listeye dönsün
            }
            else return RedirectToAction("Hata", "Hasar"); //false ise hata sayfası eklenir
        }

        public ActionResult Goster(int? id)
        {
            return View(new Details().GetSelected(id)); //id'li hasarı getirir
        }
        public ActionResult Duzenle(int? id)
        {
            return View(new Details().GetSelected(id)); //seçili olan ürünü getirir
        }
        [HttpPost]
        public ActionResult Duzenle(AracHasarBilgisi model) //hasar tablosu model olarak alınıp
        {
            return View(new Edit().EditProduct(model)); //model product olarak gönderilecek
        }
    }
}