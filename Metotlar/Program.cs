using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Aciklama = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product1.Adi);
                Console.WriteLine(product1.Fiyati);
                Console.WriteLine(product1.Aciklama);
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine("----------------Metotlar------------------");

            SepetManeger sepetManeger = new SepetManeger();
            sepetManeger.Ekle(product1);
            sepetManeger.Ekle(product2);
            Console.WriteLine("-------------------------------------");
            sepetManeger.Ekle2("Armut", "Yeşil armut", 12,10, "Nice");
            sepetManeger.Ekle2("Elma", "Yeşil elma", 12,9, "Nice");
            sepetManeger.Ekle2("Karpuz", "Diyarbakır karpuzu",12, 8,"Nice");

        }
    }
}
