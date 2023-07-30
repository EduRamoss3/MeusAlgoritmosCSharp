using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAccounts.Entities
{
    abstract class Account
    {
        public int Number { get; set; }
        public double LoanLimit { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public Account()
        {

        }
        public Account(int number, double loanLimit, string name, double balance)
        {
            Number = number;
            LoanLimit = loanLimit;
            Name = name;
            Balance = balance;
        }   
        public void withDram(double amount)
        {
            Balance -= amount;
        }
        public void deposit(double amount)
        {
            Balance += amount;
        }
    }

}
