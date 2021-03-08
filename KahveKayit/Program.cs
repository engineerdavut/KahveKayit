using KahveKayit.Abstract;
using KahveKayit.Concrete;
using KahveKayit.Adaptors;
using MernisServiceReference;
using System;

namespace KahveKayit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BaseMusteriManager musteriManager = new StarbucksMusteriManager(new MernisServiceAdaptor());
            musteriManager.Kaydet(new Entities.Musteri { Adi = "davut", DogumYili = new DateTime(1991, 2, 11), ID = 1, Soyad = "aktaş", TcNo = "245347" });
            Console.ReadLine();
        }
    }
}
