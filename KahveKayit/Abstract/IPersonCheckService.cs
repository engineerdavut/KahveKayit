using KahveKayit.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveKayit.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Musteri musteri);
    }
}
