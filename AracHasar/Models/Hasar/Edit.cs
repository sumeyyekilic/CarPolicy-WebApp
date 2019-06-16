using AracHasar.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AracHasar.Models.Hasar
{
    public class Edit
    {
        private data.GirisDBEntities6 db;
        public Edit()
        {
            db = new data.GirisDBEntities6(); //veritabaı oluşturuldu

        }
        public AracHasarBilgisi EditProduct(AracHasarBilgisi model) //hasar tablosunda bir model geleceği içi
                                                                    //hasar tablosunda bir parametre atandı
        {
            AracHasarBilgisi resulProduct = db.AracHasarBilgisi.Find(model.ID); //hasartablosundan ıd yi refere edek hasarı bulr
            resulProduct.PlakaNo = model.PlakaNo; //
            resulProduct.MotorNo = model.MotorNo;
            resulProduct.ListeTipi = model.ListeTipi;
            resulProduct.Acente = model.Acente;
           resulProduct.Sube = model.Sube;
           resulProduct.HasarBolgesi = resulProduct.HasarBolgesi;
            resulProduct.HasarDerecesi = model.HasarDerecesi;
           resulProduct.KazaSebebi = model.KazaSebebi;
            resulProduct.KazaTarihi = model.KazaTarihi;

          db.Entry(resulProduct).State = System.Data.Entity.EntityState.Modified; //düzenlendiği entitiye söylernir
            db.SaveChanges();
            return resulProduct; //parametre dönderilsin

        }
    }
}