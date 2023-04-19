using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicaoTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double day = 20.0;
            double resultado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double preco = (resultado > day)?  21 : 16;
            Console.Write(preco);

            string ultr = Console.ReadLine();
            string search = (ultr == "M") ? "OO" : "N";

            int optm = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int optB = (optm > 4) ? 130 :  optm;

            bool alue = false;
            bool alum = (alue) ? true : false;
        }
    }
}
