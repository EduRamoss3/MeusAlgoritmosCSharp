using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDolar
{
public static class ConversorDeMoeda
    {
        public static double Cotacao_Dolar;
        public static double Dolar_comprado;
        public static double Iof = 6.0;
        public static double Converter(double Cotacao_Dolar,double Dolar_comprado)
        {
            double total = Cotacao_Dolar * Dolar_comprado;
            return total + total * Iof / 100.0;
        }

    }
}
