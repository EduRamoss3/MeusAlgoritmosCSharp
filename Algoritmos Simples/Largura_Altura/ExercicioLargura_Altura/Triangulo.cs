using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLargura_Altura
{
    internal class Triangulo
    {
        public double Altura;
        public double Largura;
        public double Area()
        {

            return Altura * Largura;


        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }

}
