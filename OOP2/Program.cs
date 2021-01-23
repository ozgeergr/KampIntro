using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMüsteri musteri1 = new GercekMüsteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "demirog";
            musteri1.TcNo = "111111111";
            musteri1.Id = 1;


            //kodlamaio
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri (birbirinin yerine kullanılamaz)
            // SOLID (L)

            Musteri musteri3 = new GercekMüsteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



              
        }
    }
}
