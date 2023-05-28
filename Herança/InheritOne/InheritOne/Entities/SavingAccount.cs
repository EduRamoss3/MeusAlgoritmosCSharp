using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritOne.Entities
{
    internal class SavingAccount : Account
    {
        public double interestRate { get; set; }

        public SavingAccount()
        {

        }

        public SavingAccount(string holder, int number, double balance, double interestRate)
           : base(holder, number, balance)
        {
            this.interestRate = interestRate;
        }
    }
}
