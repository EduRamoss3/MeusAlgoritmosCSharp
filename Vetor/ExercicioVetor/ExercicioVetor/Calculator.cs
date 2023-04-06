using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetor
{
    internal class Calculator
    {
        public int Numero;
        public static int Sum( params int[] numbers)

        {
            int sum = 0;
              for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
        public Calculator(int numero)
        {
            Numero = numero;
           
        }
    }
}
