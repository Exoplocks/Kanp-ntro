using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string Kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string Kurs2 = "Proglamlamaya Başlangıç için temel kurs";
            string Kurs3 = "java";

            // array - dizi

            string[] Kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Proglamlamaya Başlangıç için temel kurs", "java" }; 
            
            for (int i = 0; i<Kurslar.Length; i++)// yada i+=2 de denebilir
            {
                Console.WriteLine(Kurslar[i]);
            }

            foreach (string Kurs in Kurslar)
            {
                Console.WriteLine(Kurs);
            }


            Console.WriteLine("Sayfa Sonu");
        }
    }
}
