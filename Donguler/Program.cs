using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // tekrar edenler için kullanılan yapı- döngü
            // i- sayaç (yaşam döngüsü)
            // (array) dizilerle tanımlama yapılır - ürünler  
            // foreach dizi elemanları tek tek dolanır 

            string[] kurslar = new string[] { " Yazılımcı Geliştirici Yetiştirme Kampı",
                " Programlamaya başlangıç için temel kurs",
                "java", "python"};

            
            
            for (int i = 0; i< kurslar.Length; i++)

            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);           
            }

            Console.WriteLine("sayfa sonu - footer");

        }
    }
}
