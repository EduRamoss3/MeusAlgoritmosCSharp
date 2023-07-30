using Shapes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius, Colors color) : base (color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
