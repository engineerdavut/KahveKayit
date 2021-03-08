using KahveKayit.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveKayit.Entities
{
    public class Musteri : IEntity
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }

        public DateTime DogumYili { get; set; }

        public string TcNo { get; set; }
    }
}
