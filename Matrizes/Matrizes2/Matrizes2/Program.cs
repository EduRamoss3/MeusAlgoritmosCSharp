using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            Console.WriteLine("Digite um numero inteiro: ");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero inteiro: ");
            N = int.Parse(Console.ReadLine());

            int[,] MatrizP = new int[M, N];

             for(int i = 0; i < M; i++)
            {
                
                Console.WriteLine("Digite +"+ N+" valores para a matriz:");
                string[] numero = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {

                    MatrizP[i, j] = int.Parse(numero[j]);
                    

                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(MatrizP[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Info sobre  o numero:");
            int X = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (MatrizP[i, j] == X)
                    {
                        Console.WriteLine("Position: " + "("+ i + ","+ j + ")");

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + MatrizP[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + MatrizP[i - 1, j]);
                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine("Right: " + MatrizP[i, j + 1]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Down: " + MatrizP[i + 1, j]);
                        }

                    }

                 
                }
               
            }

            

        }
    }
}
