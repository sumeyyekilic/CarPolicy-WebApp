using AracHasar.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AracHasar.Models.Hasar
{
    public class Details
    {
        private data.GirisDBEntities6 db; //db olu
        public Details()
        {
            db = new data.GirisDBEntities6(); //db nesne olarak tanım
        
        }
        public AracHasarBilgisi GetSelected(int ?id) // seçileni getiren bir metot
        {
            return db.AracHasarBilgisi.Find(id); //id bulup geriye döndersin
        }
    }
}