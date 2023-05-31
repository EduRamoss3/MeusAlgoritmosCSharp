using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsTag.Entities;
using ProductsTag.Entities.Enums;

namespace ProductsTag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int enterNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < enterNumber; i++)
            {
                Console.WriteLine($"\nProduct #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                switch (type)
                {
                    case 'c':
                        {
                            Console.Write("Name: ");
                            string cName = Console.ReadLine();
                            Console.Write("Price: " );
                            double cPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Types cType;
                            string nameOfType = "Common";
                            Enum.TryParse(nameOfType, true, out cType);
                            Product product = new Product(cName, cPrice, cType);
                            products.Add(product);
                            break;
                        }
                    case 'u':
                        {
                            Console.Write("Name: ");
                            string uName = Console.ReadLine();
                            Console.Write("Price: ");
                            double uPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Manufacture date (DD/MM/YYYY): ");
                            DateTime uDate = DateTime.Parse(Console.ReadLine());
                            Types uType;
                            string nameOfType = "UsedProduct";
                            Enum.TryParse(nameOfType, true, out uType);
                            UsedProduct usedProduct = new UsedProduct(uName, uPrice, uDate, uType);
                            products.Add(usedProduct);
                            break;
                        }
                    case 'i':
                        {
                            Console.Write("Name: ");
                            string iName = Console.ReadLine();
                            Console.Write("Price: ");
                            double iPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Customs fee: ");
                            double iCommonFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Types iType;
                            string nameOfType = "ImportedProduct";
                            Enum.TryParse(nameOfType, true, out iType);
                            ImportedProduct importedProduct = new ImportedProduct(iName, iPrice, iCommonFee, iType);
                            products.Add(importedProduct);
                            break;
                        }
                        
                    
                }
             
            }
            
            foreach(Product product in products)
            {
                Console.WriteLine("\n"+product.priceTag());
            }
            Console.ReadKey();

           
        }
    }
}
