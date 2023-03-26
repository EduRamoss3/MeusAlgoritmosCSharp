namespace ConsoleApp3;
 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Descubra a pessoa mais velha.");
        Console.WriteLine("Digite o nome da pessoa:");
        Pessoa P1 = new Pessoa();
        P1.Nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da pessoa: ");
        P1.Idade= int.Parse(Console.ReadLine());

        Pessoa P2 = new Pessoa();
        Console.WriteLine("Digite o nome da segunda pessoa: ");
        P2.Nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da segunda pessoa: ");
        P2.Idade = int.Parse(Console.ReadLine());

        if (P1.Idade > P2.Idade)
        {
            Console.WriteLine("A pessoa mais velha é: " + P1.Nome);
        }
        else
        {
            Console.WriteLine("A  pessoa mais velha é: " + P2.Nome);
        }
        
        
             

    
    }
}