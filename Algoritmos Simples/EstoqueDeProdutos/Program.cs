using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.Security.AccessControl;

namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            Produto P = new Produto();
            Produto X = new Produto();
            P.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: ");
               P.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a quantidade em estoque? ");
               P.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(P.ToString(),CultureInfo.InvariantCulture);
            P.MostrarOpcoes();
            int num = int.Parse(Console.ReadLine());

             while(num  > 0 &&  num < 5)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Dados do produto: " +P + " , " + X);
                        P.MostrarOpcoes();
                        num = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        int quantidade;
                        Console.WriteLine("Qual a quantidade? ");
                             quantidade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dados do produto: " + P + " , " + X);

                        P.MostrarOpcoes();
                             num = int.Parse(Console.ReadLine());


                        while (P.Quantidade + quantidade < 1)
                        {           
                            Console.WriteLine("Digite um número maior que 0");
                            quantidade = int.Parse(Console.ReadLine());

                        }

                        P.AdicionarProdutos(quantidade);
                        Console.WriteLine("Dados do produto: " + P + " , " + X);
                    break;

                    case 3:
                        Console.WriteLine("Qual a quantidade? ");
                          int quantidadeRemover = int.Parse(Console.ReadLine());
                        if (P.Quantidade - quantidadeRemover < 0)
                        {
                            Console.WriteLine("Valor de estoque já zerado.");
                            P.MostrarOpcoes();
                            num = int.Parse(Console.ReadLine());
                            break;
                        }
                        else
                        {
                            P.RemoverProdutos(quantidadeRemover);
                            Console.WriteLine("Dados do produto: " + P +" , "+ X);
                            P.MostrarOpcoes();
                            num = int.Parse(Console.ReadLine());
                        }
 
                        break;
                    case 4:
                        Console.WriteLine("Qual o nome do produto?");
                       
                     
                          X.Nome = Console.ReadLine();
                        Console.WriteLine("Qual o preço do produto?");
                           X.Preco = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a quantidade?");
                           X.Quantidade = int.Parse(Console.ReadLine());
                        P.MostrarOpcoes();
                        num = int.Parse(Console.ReadLine());



                        break;
                    default: Console.WriteLine("Número invalido.");

                        break;
                        

                }
            }



        }
    }
}
