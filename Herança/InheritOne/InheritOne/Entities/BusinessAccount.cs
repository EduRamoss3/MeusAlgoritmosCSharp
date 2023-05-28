using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritOne.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }
        public BusinessAccount(string holder ,int number, double balance ,double loanLimit) 
            :base (holder, number, balance)
        {
            LoanLimit = loanLimit;
        }
        public void Loan(double amount)
        {
            if( amount <= LoanLimit)
            {
                Balance += amount;
            }
            
        }
    }
}
