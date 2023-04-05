using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Estudantes[] vect = new Estudantes[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudantes(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quarto ocupados:");
             for(int i =0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i+ ":  "+vect[i]);

                }
            }

        }
    }
}