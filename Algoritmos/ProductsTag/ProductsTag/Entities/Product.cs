using ProductsTag.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTag.Entities
{
    internal class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Types Type { get; set; }

       

        public Product()
        {

        }
        public Product(string name, double price,  Types type)

        {
           
            Name = name;
            Price = price;
            Type = type;
        }


        public virtual string priceTag()
        {
            return Name
                + " $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " Type: ("+Type+")";
        }
    }
}
