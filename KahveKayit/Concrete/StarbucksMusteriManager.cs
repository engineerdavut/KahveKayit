using KahveKayit.Abstract;
using KahveKayit.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveKayit.Concrete
{
    public class StarbucksMusteriManager:BaseMusteriManager
    {
        private IPersonCheckService _personCheckService;



        public StarbucksMusteriManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Kaydet(Musteri musteri)
        {
            
            if (_personCheckService.CheckIfRealPerson(musteri))
            {
                base.Kaydet(musteri);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

    }
}
