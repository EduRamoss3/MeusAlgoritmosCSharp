using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewAccounts.Entities;

namespace NewAccounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new SavingsAccount(1001,"Alex", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1001, "Alex", 500.0,400.0));
            double sum = 0.0;
            foreach(Account acc in accounts)
            {
                sum += acc.Balance;
            }
            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
