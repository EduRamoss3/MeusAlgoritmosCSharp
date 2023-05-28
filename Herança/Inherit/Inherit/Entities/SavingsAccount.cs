using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit.Entities
{
    sealed class SavingsAccount : Account
    {
        public SavingsAccount()
        {

        }
        public SavingsAccount(string holder, int accountNumber, double balance, string type ) : base(holder, accountNumber, balance, type)
        {

        }
        public sealed override void WithDraw(double amount)
        {
            Balance -= amount;
           
        }
    }
}
