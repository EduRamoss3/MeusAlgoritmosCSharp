using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
{
    abstract internal class Pessoa
    {
        public string Name { get; set; }
        public double Annual { get; set; }
        public Pessoa(string name, double annual)
        {
            Name = name;
            Annual = annual;
        }

        public abstract double Taxes();
    }
}
