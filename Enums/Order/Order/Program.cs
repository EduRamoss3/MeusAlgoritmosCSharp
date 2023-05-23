using Course.Entities;
using Order.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            string Name = Console.ReadLine();
            Console.WriteLine("Email:");
            string Email = Console.ReadLine();
            Console.WriteLine("Birth Date DD/MM/YYYY:");
            string BirthDate = Console.ReadLine();
            DateTime datetime = DateTime.Parse(BirthDate);

          

            Console.WriteLine("Enter order data:");
            Console.WriteLine("Status:");
            string Type = Console.ReadLine();
            OrderStatus os;
            Enum.TryParse(Type, true, out os);
            Client client = new Client(Name, Email, datetime);
            Orderr order = new Orderr(DateTime.Now, os, client);
            


            Console.WriteLine("How many items to this order?");
            int Items = int.Parse(Console.ReadLine());
            for(int i = 0; i < Items; i++)
            {
                Console.WriteLine($"Enter the #{i+1} item data:");
                Console.Write("Product name:");
                string ProductName = Console.ReadLine();
                Console.WriteLine("Product price:");
                double ProductPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Product product = new Product(ProductName, ProductPrice);


                Console.Write("Quantity:");
                int Quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(Quantity, ProductPrice , product);

                order.AddItem(orderItem);   
                
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);
            Console.ReadKey();
        }
    }
}
