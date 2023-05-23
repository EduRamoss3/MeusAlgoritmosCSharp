using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Entities
{
    internal class Product
    {
        public string NameProduct { get; set; }
        public double Price { get; set; }   

        public Product(string nameProduct, double price)
        {
            NameProduct = nameProduct;
            Price = price;
        }   
        public Product()
        {

        }
    }
}
