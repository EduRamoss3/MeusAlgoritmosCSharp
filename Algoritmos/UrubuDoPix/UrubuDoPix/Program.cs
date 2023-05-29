using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using UrubuDoPix.Entities;

namespace UrubuDoPix
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            
            Console.WriteLine("URUBU DO PIX");
            Console.Write("Usuário:");
            string userName = Console.ReadLine();
            User user = new User(userName);
            Console.WriteLine("1 - Depositar , 2 - Sacar , 3 - Resumo");
            int switchNum = int.Parse(Console.ReadLine());
            Transaction transaction = new Transaction(user);
            Resume resume = new Resume();

            switch (switchNum)
            {
                case 1:
                    {

                        Console.Write("Quanto deseja depositar? ");
                        double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        transaction.Deposit(amount);
                        resume.addChanges(transaction);
                        Console.WriteLine(transaction.ToString());
                        Console.WriteLine(resume.ToString());


                        break;
                    }
                case 2:
                    {
                        Console.Write("Quantia de saque: ");
                        double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        transaction.withDraw(amount);
                        resume.addChanges(transaction);
                        Console.WriteLine(transaction.ToString());
                        Console.WriteLine(resume.ToString());


                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(transaction.ToString());
                        Console.WriteLine(resume.ToString());
              
                        break;
                    }
                
                
            }
            transaction.Profit(DateTime.Now);
            Console.ReadKey();
        }

       

        
    }
}
