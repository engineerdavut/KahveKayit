using KahveKayit.Abstract;
using KahveKayit.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveKayit.Adaptors
{
    class MernisServiceAdaptor : IPersonCheckService
    {
        public bool CheckIfRealPerson(Musteri musteri)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrula(Convert.ToInt64(musteri.TcNo), musteri.Adi.ToUpper(),musteri.Soyad.ToUpper(),musteri.DogumYili.Year);

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            //return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(musteri.TcNo), musteri.Adi.ToUpper(), musteri.Soyad.ToUpper(), musteri.DogumYili.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
