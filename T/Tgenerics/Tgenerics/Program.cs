using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgenerics.Entities;

namespace Tgenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();

            Console.WriteLine("Enter N");
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Price: ");
                double Price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Products product = new Products(Name, Price);
                list.Add(product);
            }
            Console.WriteLine("Max: ");
            CalculationService calculationService = new CalculationService();
            Products Max = calculationService.Max(list);
            Console.WriteLine(Max);

        }
    }
}
