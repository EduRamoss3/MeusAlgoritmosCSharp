using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        private double Price;
        protected double GetPrice()
        {
            return Price;
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return Name + ", " + Price;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Product other = obj as Product;
            if(!(obj is Product)) { return false; }
            return Name.Equals(other.Name);
        }

    }
}
