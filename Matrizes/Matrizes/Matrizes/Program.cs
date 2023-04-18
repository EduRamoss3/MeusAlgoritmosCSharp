using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para a matriz:");
            int p = int.Parse(Console.ReadLine());

            int[,] Matriz = new int [p, p];
              for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite três numeros inteiros:");
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < 3; j++)
                {
                    Matriz[i, j] = int.Parse(values[j]);
                    
                }
            }

              for(int n = 0; n < 3; n ++) {

                for(int b = 0; b < 3; b++)
                {
                    Console.Write(Matriz[n, b] +" ");
                }
                Console.WriteLine();
            }
            int count = 0;

              for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("Diagonal principal:" + Matriz[i, i]);
                    if (Matriz[i,j] < 0)
                    {
                        count++;
                    }
                    Console.WriteLine("Negativos: " + count);
                }
            }
            
        }
    }
}
