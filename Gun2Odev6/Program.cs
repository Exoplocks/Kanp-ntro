using System;

namespace Gun2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.ProductMetariels = "Gold";
            Product1.ProductPrice = 825;
            Product1.ProductProducer = "Öksüt Madencilik Sanayi ve Ticaret A.Ş.";

            Product Product2 = new Product();
            Product2.ProductMetariels = "İron";
            Product2.ProductPrice = 190;
            Product2.ProductProducer = "Ereğli Demir ve Çelik Fabrikaları T.A.Ş.";

            Product Product3 = new Product();
            Product3.ProductMetariels = "aluminum";
            Product3.ProductPrice = 320;
            Product3.ProductProducer = "Akpa Alüminyum";

            Product[] products = new Product[] { Product1, Product2, Product3 };

            foreach (var Product in products)
            {
                Console.WriteLine("Metarials:" + Product.ProductMetariels + " Price: " + Product.ProductPrice + " Producer: " + Product.ProductProducer);
            }

            //for (int i = 0; i < products.Length; i++)
            {
                //Console.WriteLine(products[i]);
            }
            
        } 
        class Product
        {
            public string ProductMetariels { get; set; }
            public int ProductPrice { get; set; }  
            public string ProductProducer { get; set; }
        }
    }
}
