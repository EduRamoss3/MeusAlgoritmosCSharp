using System.Globalization;

namespace AprovadoReprovado;
 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do aluno:");
          Aluno Y = new Aluno();
           Y.Nome_Aluno = Console.ReadLine();
        Console.WriteLine("Digite a nota do aluno no primeiro semestre, valendo 30 pontos:");
           double nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

         while(nota1 > 30 && nota1 < 0)
        {
            Console.WriteLine("Numero invalido, tente novamente ( entre 0 e 30): ");
            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        }
            Y.Nota1 = nota1;

        Console.WriteLine("Digite a nota do aluno no segundo semestre, valendo 35 pontos:");
           double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (nota2 > 35 && nota1 < 0)
        {
            Console.WriteLine("Numero invalido, tente novamente ( entre 0 e 35): ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
          Y.Nota2 = nota2;
        Console.WriteLine("Digite a nota do aluno no terceiro semestre, valendo 35 pontos:");
        double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (nota3 > 35 && nota1 < 0)
        {
            Console.WriteLine("Numero invalido, tente novamente ( entre 0 e 35): ");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        Y.Nota3 = nota3;

       Y.Resultado();
    }
}