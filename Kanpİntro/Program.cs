using System;

namespace Kanpİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            //DO not repat yourself 
            // değer tutucu 
            
            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisiMi = false;
            double DolarDun = 7.35;
            double DolarBugun = 7.45;


            if (DolarDun > DolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi"); 
            }

            if (sistemeGirisYapmisiMi == true )  
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");                
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(faizOrani);

            Console.WriteLine(ogrenciSayisi);

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
