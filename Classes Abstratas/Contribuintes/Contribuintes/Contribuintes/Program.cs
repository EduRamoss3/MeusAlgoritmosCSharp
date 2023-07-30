using Contribuintes.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Console.Write("Qual a quantidade de funcionarios a ser registrada?: ");
            int number = int.Parse(Console.ReadLine());
            for( int i = 1; i <= number; i++)
            {
                Console.Write("Pessoa fisica (f) ou Juridica (j) ? ");
                char person = char.Parse(Console.ReadLine());
                switch (person)
                {
                    case 'f':
                        {
                            Console.Write("Nome: ");
                            string Nome = Console.ReadLine();
                            Console.Write("Renda anual: ");
                            double Renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Gastos com a saúde: ");
                            double Gastos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            PessoaFisica pessoaFisica = new PessoaFisica(Gastos, Nome, Renda);
                            pessoas.Add(pessoaFisica);
                            
                            break;
                        }
                    case 'j':
                        {
                            Console.Write("Nome: ");
                            string Nome = Console.ReadLine();
                            Console.Write("Renda anual: ");
                            double Renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Write("Qnt de funcionários: ");
                            int qntFunc = int.Parse(Console.ReadLine());
                            PessoaJuridica pessoaJuridica = new PessoaJuridica(qntFunc, Nome, Renda);
                            pessoas.Add(pessoaJuridica);
                            break;
                        }
                }

            }
            foreach(Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Name);
                Console.WriteLine("Renda anual + "+ (pessoa.Annual).ToString());
                Console.WriteLine("Taxas: R$" + pessoa.Taxes().ToString("F2",CultureInfo.InvariantCulture));

            }
            Console.ReadKey();
        }
    }
}
