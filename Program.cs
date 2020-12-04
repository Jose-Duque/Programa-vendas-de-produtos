using System;
using System.Collections.Generic;
using System.Globalization;
using Vendas.Entities;

namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>(); 

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i) ? ");
                char type = char.Parse(Console.ReadLine());
                if(type == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(date, name, price ));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(customs, name, price));
                }             
                
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags");
            foreach (Product product in products)
            {

                Console.WriteLine(product.PriceTag());

            }
        }
    }
}
