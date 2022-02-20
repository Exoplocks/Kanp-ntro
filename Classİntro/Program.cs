using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin Demirog";
            int yas = 36;

            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "C#";
            Kurs1.KursunEgitmeni = "Engin Demiroğ";
            Kurs1.İzlenmeorani = 68;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "Java";
            Kurs2.KursunEgitmeni = "Kerem Varış";
            Kurs2.İzlenmeorani = 64;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "Pyhton";
            Kurs3.KursunEgitmeni = "Berkay Bilgin";
            Kurs3.İzlenmeorani = 80;

            Kurs[] Kurslar = new Kurs[] {Kurs1, Kurs2, Kurs3 };

            foreach (var Kurs in Kurslar )
            {
                Console.WriteLine(Kurs.KursAdi + " : " + Kurs.KursunEgitmeni);
            }

            Console.WriteLine("Foreach bitti");

            //for (int i = 0; i<Kurslar.Length; i++)
            //{
                //Console.WriteLine(Kurslar[i]);
            //}

            //Console.WriteLine(Kurs1.KursAdi + " : " + Kurs1.KursunEgitmeni);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int İzlenmeorani { get; set; }
    }
}
