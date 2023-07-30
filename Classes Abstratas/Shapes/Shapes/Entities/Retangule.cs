using Shapes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Entities
{
    internal class Retangule : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Retangule(double width, double height, Colors color) : base (color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
