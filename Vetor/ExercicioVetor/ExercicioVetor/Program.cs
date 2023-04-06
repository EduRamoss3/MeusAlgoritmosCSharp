using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s2 = Calculator.Sum(new int[] { 10, 20, 30, 40 });
            int s1 = Calculator.Sum(2, 4, 3);

           int[]soma1 = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Entre com um número:");
                int num = int.Parse(Console.ReadLine());
                soma1[i] = num;

            }

            int s3 = Calculator.Sum(soma1);
            Console.WriteLine(s3);
            Console.Write(s2);
            Console.Write(s1);

        }
    }
}
