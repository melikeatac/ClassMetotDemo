using System;
using System.Collections.Generic;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            Product product2 = new Product{Id = 2,CategoryId = 5,UnitsInStock = 5,
                UnitPrice = 35,ProductName = "Kalem"};
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

            Console.WriteLine("*****************");
            string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            List<string> isimler2 = new List<string> { "engin", "Murat", "Kerem", "Halil" };
            isimler2.Add("Elif");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[4]);

        }
    }
}
