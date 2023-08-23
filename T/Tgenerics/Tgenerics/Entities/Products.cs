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
            return "Nome: " + Name + " ," + Price.ToString("F2",CultureInfo.InvariantCulture);
        }

        public int CompareTo(Products products)
        {
            if(!(products is Products))
            {
                throw new ArgumentException("Comparing error!");
            }
            Products other = products;
            return Price.CompareTo(other.Price);
        }
    }
}
