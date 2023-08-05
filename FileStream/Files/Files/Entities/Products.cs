using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files.Entities
{
    internal class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }   
        public int Quantity { get; set; }
        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public double Total()
        {
            return Price * Quantity;
        }
    }
}
