using AracHasar.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AracHasar.Models.Hasar
{
    public class List
    {
        private data.GirisDBEntities6 db;
        public List()
        {
            db = new data.GirisDBEntities6();
        }
        public IEnumerable<AracHasarBilgisi> GetAll() //cshtml sayfasında IEnumerable türünde
        {
            return db.AracHasarBilgisi.ToList(); //geri değer gönderiyor
        }
    }
}