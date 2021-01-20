using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1= new Kurs();
            kurs1.kursAdi = "c#";
            kurs1.Egitmen = "engin demirog";
            kurs1.İzlenmeOrani = "30";

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "java";
            kurs2.Egitmen = "kerem öz";
            kurs2.İzlenmeOrani ="48";

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = " python";
            kurs3.Egitmen = "özlem benk";
            kurs3.İzlenmeOrani = "40";

            //Console.WriteLine(kurs1.kursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs [] {kurs1,kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi+ ":" +kurs.Egitmen);
            }






            
        }
    }

    class Kurs 
    {
        public  string kursAdi { get; set; }
        public  string Egitmen { get; set; }
        public  string İzlenmeOrani { get; set; }
    }
}
