using ExercicioDolar;
using System.Globalization;

Console.WriteLine("QUAL A COTAÇÃO DO DOLAR ATUALMENTE:");
ConversorDeMoeda.Cotacao_Dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("QUANTOS DOLARES VOCÊ DESEJA:");
ConversorDeMoeda.Dolar_comprado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double ValorFinal;
ValorFinal = ConversorDeMoeda.Converter(ConversorDeMoeda.Cotacao_Dolar,ConversorDeMoeda.Dolar_comprado);
Console.WriteLine("O valor a ser pago em reais é de " + ValorFinal);


