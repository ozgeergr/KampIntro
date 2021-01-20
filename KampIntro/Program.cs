using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself- kendini tekrarlama
            // kategori etiketi değer tutucu 
            // bool- sisteme giriş yapmış mı 


            string kategoriEtiketi = "Kategoriler";
            int ogrensiSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.75;
            double dolarBugun = 7.45;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Artış Butonu ");

            }

            else
            {

                Console.WriteLine("Değişmedi butonu");
            }

            
            
            
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu ");
            }
            else
            {
                Console.WriteLine(" Giriş yap butonu");
            }

            


            Console.WriteLine(kategoriEtiketi);




        }
    }
}
