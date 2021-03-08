using KahveKayit.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveKayit.Abstract
{
    public abstract class BaseMusteriManager : IMusteriService
    {
        public virtual void Kaydet(Musteri musteri)
        {
            Console.WriteLine("Veritabanina kaydedildi "+ musteri.Adi);
        }
    }
}
