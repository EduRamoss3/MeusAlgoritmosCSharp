using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAccounts.Entities
{
    internal class SavingsAccount : Account
    {
        public double interestRate { get; set; }
        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string name, double balance, double interest)
        {
            Number = number;
            Name = name;
            Balance = balance;
            this.interestRate = interest;
        }
        public SavingsAccount(double interestRate)
        {
            this.interestRate = interestRate;
        }

        public void updateBalance()
        {
            Balance +=  interestRate; 

        }
    }
}
