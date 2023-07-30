using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Entities.Enums;

namespace Shapes.Entities
{
    abstract class Shape
    {
        public Colors Color { get; set; }
        public Shape(Colors color)
        {
            Color = color;
        }   

        public abstract double Area();
      
    }
}
