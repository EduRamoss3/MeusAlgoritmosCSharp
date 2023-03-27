using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AutoPropertys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oculos[] Otica = new Oculos[20];
            Console.WriteLine("1 - CADASTRAR NOVO ÓCULOS , 2- LISTAR TODOS OS PRODUTOS, 3- SAIR");
            int numEscolha = int.Parse(Console.ReadLine());
            while (numEscolha > 0 && numEscolha < 3)
            {



                switch (numEscolha)
                {
                    case 1:
                        {

                            for (int i = 0; i < 1; i++)
                            {
                                Oculos V = new Oculos();
                                Console.WriteLine("Nome do óculos: ");
                                V.Nome = Console.ReadLine();
                                Console.WriteLine("Preço do óculos: ");
                                V.Preco = double.Parse(Console.ReadLine());
                                Console.WriteLine("Quantidade: ");
                                V.Quantidade = int.Parse(Console.ReadLine());
                                Otica[i] = V;
                            }
                            Console.WriteLine("1 - CADASTRAR NOVO ÓCULOS , 2- LISTAR TODOS OS PRODUTOS, 3- SAIR");
                            numEscolha = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 2:
                        {
                            foreach (Oculos X in Otica)
                            {
                                Console.WriteLine("Nome do produto:" + X.Nome + "|Quantidade|" + X.Quantidade + "|Preço|" + X.Preco); ;
                            }

                            Console.WriteLine("1 - CADASTRAR NOVO ÓCULOS , 2- LISTAR TODOS OS PRODUTOS, 3- SAIR");
                            numEscolha = int.Parse(Console.ReadLine());
                            
                        }
                        break;


                }





            }
        }
    }
}
