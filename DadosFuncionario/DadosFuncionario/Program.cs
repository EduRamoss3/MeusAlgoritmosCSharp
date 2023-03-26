using System;
using System.Globalization;
namespace DadosFuncionario;
 class Program
{
     static void Main(string[] args)
    {
        Funcionario X = new Funcionario();
        Console.WriteLine("Digite o nome do funcionário: ");
        X.Nome = Console.ReadLine();
        Console.WriteLine("Digite o salario bruto: ");
        X.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Digite a porcentagem do imposto: ");
        X.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.WriteLine("Nome do funcionário: "+X.Nome.ToString(CultureInfo.InvariantCulture)+
            "Salario liquido:"+ X.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine("Aumentar o salário em porcentagem: ");
        double Porcentagem;
        Porcentagem = double.Parse(Console.ReadLine());
        X.AumentarSalario(Porcentagem);
        Console.WriteLine("Nome do funcionário: " + X.Nome.ToString(CultureInfo.InvariantCulture) + "" +
           "Salario liquido:" + X.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

    }
}