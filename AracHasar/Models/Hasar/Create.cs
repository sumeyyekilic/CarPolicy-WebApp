using AracHasar.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AracHasar.Models.Hasar
{
    public class Create
    {
        private data.GirisDBEntities6 db; //entities data modeli eklenerek db adından data oluşturuluyor.
        public Create() //public yapılandırıcı metoduna düştüğünde 
        {
            db = new data.GirisDBEntities6(); //eklediği aracı geri gönersin
        }

        public AracHasarBilgisi Add(AracHasarBilgisi model) //model türünde referans alındı.
        {
            db.AracHasarBilgisi.Add(model); //model ekleniyor
            db.SaveChanges(); // db kaydediliyor
            return model; //ve model geri gönderiliyor.
        }
    }
}