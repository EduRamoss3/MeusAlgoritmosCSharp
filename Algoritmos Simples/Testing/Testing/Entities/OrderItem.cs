using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }   
        public double subTotal(int Quantity, double Price)
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return   product.NameProduct
                    + ", Quantity:" + Quantity
                    + " , Subtotal: $" + Price.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
