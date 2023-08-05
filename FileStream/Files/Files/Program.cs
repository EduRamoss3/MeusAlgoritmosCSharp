using Files.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();
            string sourcePath = @"C:\Users\Eduardo\source";
            string targetPath = sourcePath + @"\items1";
            string newPath = targetPath + @"\out";
            Directory.CreateDirectory(targetPath);
            Directory.CreateDirectory(newPath);
            using (StreamWriter streamWriter = new StreamWriter(targetPath + @"\summary.csv"))
            {
                Console.WriteLine("Qual o nome do produto?");
                string name = Console.ReadLine();
                Console.WriteLine("Qual o preço?");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a quantidade?");
                int quantity = int.Parse(Console.ReadLine());


                Products product = new Products(name, price, quantity);
                products.Add(product);
                foreach (Products p in products)
                {
                    streamWriter.WriteLine("Nome do produto: " + p.Name + "," + "Preço: " + p.Price + "," + "Quantidade:" + p.Quantity);
                }

            }
            string[] lines = File.ReadAllLines(newPath + @"\newsummary.csv");

            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                string name = fields[0];
                double price = double.Parse(fields[3]);
                int quantity = int.Parse(fields[5]);

                Products prod = new Products(name, price, quantity);
                using(StreamWriter sr = new StreamWriter(newPath + @"\newsummary.csv"))
                {
                    sr.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                }
                

            }

        }
    }
}
