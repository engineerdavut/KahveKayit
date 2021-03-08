using KahveKayit.Abstract;
using KahveKayit.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveKayit.Concrete
{
    public class MusteriCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Musteri musteri)
        {
           return true;
        }

    }
}
