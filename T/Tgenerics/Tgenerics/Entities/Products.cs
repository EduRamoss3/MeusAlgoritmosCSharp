using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgenerics.Entities
{
    internal class Products : IComparable<Products>
    {
        protected string Name { get; set; }
        private double Price { get; set;  }
        public Products(string name, double price)
        {
            Name = name;
            Price = price;

        }
        public override string ToString()
        {
            return "\n" + Name + " ," + Price.ToString("F2",CultureInfo.InvariantCulture);
        }

        public int CompareTo(Products products)
        {

            Products other = products;
            return Price.CompareTo(other.Price);
        }
    }
}
