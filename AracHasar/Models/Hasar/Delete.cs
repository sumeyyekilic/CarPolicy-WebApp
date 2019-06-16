using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AracHasar.Models.Hasar
{
    public class Delete
    {
        private data.GirisDBEntities6 db; //db oluşturuldu
        public Delete() //yapılandırıcı tanım
        {
            db = new data.GirisDBEntities6();
        }
        public bool DeleteState(int? id)
        {

            try
            {
                db.AracHasarBilgisi.Remove(db.AracHasarBilgisi.Find(id)); //hasarın veritabanı değişikliğini yapar(kaldırır)
                db.SaveChanges();// ve kaydeder
                return true; //hata oluşmadıysa true döndersin

            }
            catch (Exception)
            {
                return false; //hataya düşerse false göndersin

            }

        }
    }
}