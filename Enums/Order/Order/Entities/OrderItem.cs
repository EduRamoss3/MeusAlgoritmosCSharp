using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Entities
{
    internal class OrderItem
    {
        
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.Product = product;
        }
      
        public double SubTotal(int Quantity, double Price)
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal(Quantity, Price).ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
