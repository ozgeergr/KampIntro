using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {    
        //naming convention - doğru yazma teknikleri 
        //syntax 
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" Tebrikler ! Sepete eklendi: " + urun.Adi);

        }
        public void Ekle2(string urunAdi, string aciklama , double fiyat , int stokadedi)
        {
            Console.WriteLine(" Tebrikeler. sepete eklendi:" + urunAdi);

        }


    }
}
