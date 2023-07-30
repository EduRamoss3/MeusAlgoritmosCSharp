using Shapes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Entities;
using System.Globalization;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data:");
                Console.Write("Type of shape (c/r) ? ");
                char type = char.Parse(Console.ReadLine());
                switch (type)
                {
                    case 'c':
                        {
                            Console.WriteLine("Color: ");
                            Colors color;
                            Enum.TryParse(Console.ReadLine(), out color);

                            Console.Write("Radius: ");
                            double Radius = double.Parse(Console.ReadLine());
                            list.Add(new Circle(Radius, color));
                            break;
                        }
                    case 'r': 
                        {
                            Console.Write("Color: ");
                            Colors color;
                            Enum.TryParse(Console.ReadLine(), out color);

                            Console.Write("Width: ");
                            double Width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                            Console.Write("Height: ");
                            double Heigth = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                            list.Add(new Retangule(Width, Heigth, color));
                            break;
                        }
                }
            }
            foreach(Shape shape in list)
            {
                Console.WriteLine("SHAPE AREAS");
                Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
