using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioListas
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Solução usando listas: 
            List<Funcionario> ListaFuncionarios = new List<Funcionario>();
            Console.WriteLine("Qual a quantidade de funcionários deseja cadastrar?");
            int N = int.Parse(Console.ReadLine());
             for(int i = 0; i < N; i++)
            {
                string nome;
                int id;
                double salario;
                
                Console.WriteLine("Cadastre o nome do "+(i+1)+".O funcionário");
                nome = Console.ReadLine(); 
                Console.WriteLine("Cadastre o id do funcionario: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Cadastre o Salario do funcionário: ");
                salario = double.Parse(Console.ReadLine());

                Funcionario X = new Funcionario(id, nome, salario);
                ListaFuncionarios.Add(X);

            }
    
            Console.WriteLine("Digite o ID do funcionário para aumento de salário: ");
            int identificador = int.Parse(Console.ReadLine());

            foreach(Funcionario obj in ListaFuncionarios)
            {
                if(identificador == obj._ID)
                {
                    double porcentagem;
                    Console.WriteLine("Funcionário " + identificador + obj._Nome+", Salário atual: R$"+obj._Salario);
                    Console.WriteLine("Qual a porcentagem de aumento?");
                    porcentagem = double.Parse(Console.ReadLine());
                    obj.Aumento(identificador,porcentagem);
                    Console.WriteLine("Novo salário de "+obj._Nome+" :" + obj._Salario);
                    break;
                }
            }
            foreach(Funcionario P in ListaFuncionarios)
            {
                Console.WriteLine(P.ToString());

            }
           
        }

    }
}
