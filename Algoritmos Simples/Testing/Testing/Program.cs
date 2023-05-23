using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Entities;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, birthDate);

            Console.WriteLine("\nEnter the order data:");
            Console.Write("Status: ");
            string os = Console.ReadLine();
            OrderStatus Status;
            Enum.TryParse(os, true, out Status);        
            Console.Write("How many items to this order? ");
            int numItems = int.Parse(Console.ReadLine());
            Order order = new Order(DateTime.Now, Status, client);

            for(int i = 0; i < numItems; i++)
            {
                Console.WriteLine($"\nEnter the #{i+1} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(Quantity, productPrice, product);
                orderItem.subTotal(Quantity, productPrice);
                order.addItem(orderItem);
                
            }
            Console.WriteLine();
            Console.WriteLine("\n\t\tORDER SUMMARY");
            Console.WriteLine(order);
            Console.ReadKey();
        }
    }
}
