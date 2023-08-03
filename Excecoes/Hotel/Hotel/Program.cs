using Hotel.Entitits;
using Hotel.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for(int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Enter the account data");
                    Console.Write("Number: ");
                    int AccNumber = int.Parse(Console.ReadLine());
                    Console.Write("Holder: ");
                    string AccHolder = Console.ReadLine();
                    Console.Write("Initial balance: ");
                    double AccBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Withdraw limit: ");
                    double AccLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Account acc = new Account(AccNumber, AccHolder, AccBalance, AccLimit);
                    Console.Write("Enter the amount for withdraw: ");
                    double withDraw = double.Parse(Console.ReadLine());
                    acc.withDraw(withDraw);
                    Console.WriteLine("New balance: R$" + acc.Balance.ToString("F2",CultureInfo.InvariantCulture));
                    Console.ReadKey();
                }
                
            }
            catch(DepositException e)
            {
                Console.Write(e.Message);
                Console.ReadKey();
            }
        }
    }
}
