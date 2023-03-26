using System;
using System.Globalization;
namespace ExercicioLargura_Altura;
 class Programa
{
    static void Main(string[] args)
    {
        Triangulo X = new Triangulo();
         Console.WriteLine("Qual a altura do triangulo?");
        X.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Qual a largura do triangulo?");
        X.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("A área do triangulo é de: "+ X.Area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("O perimetro do triangulo é de: " + X.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("A diagonal do triangulo é de:" + X.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

    }
}