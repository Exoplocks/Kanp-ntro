using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManeger
    {
        public void Ekle(Product product) 
        {
            Console.WriteLine("Sepete eklendi :" + product.Adi);

        }

        public void Ekle2(string productName, string Aciklama, double Fiyat, int stokAdedi, string yorumlar) 
        {
            Console.WriteLine("Sepete eklendi :" + productName);
        }
    }
}
