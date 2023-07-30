using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAccounts.Entities
{
    internal class BusinessAccount : Account
    {
        public double loanLimit { get; set; }
        public void loan(double amount)
        {
            Balance += amount;

        }
        public BusinessAccount(int number, string name, double balance, double loan)
        {
            Number = number;
            Name = name;
            Balance = balance;
            loanLimit = loan;
        }
    }
}
