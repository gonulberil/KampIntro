using System;

namespace Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Laptop";
            product1.UnitPrice = 5000;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Telefon";
            product2.UnitPrice = 3000;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Kıyafet";
            product3.UnitPrice = 100;


            Product[] products = new Product[] { product1, product2, product3 };

            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine(products[i].Id);
            //    Console.WriteLine(products[i].Name);
            //    Console.WriteLine(products[i].UnitPrice);
            //}

            //foreach (var urun in products)
            //{
            //    Console.WriteLine(urun.Id+")"+ urun.Name+":"+ urun.UnitPrice);

            //}

            int i= 0;

            while (i<products.Length)
            {
                Console.WriteLine(products[i].Id);
                Console.WriteLine(products[i].Name);
                Console.WriteLine(products[i].UnitPrice);

                i++;
            }

        }

    }
}