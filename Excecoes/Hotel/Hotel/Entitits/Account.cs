using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Exceptions;
namespace Hotel.Entitits
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }
       public Account(int number, string holder, double balance, double limit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = limit;  
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void withDraw(double amount)
        {
            if(Balance < 0)
            {
                throw new DepositException("Saldo inexistente");
            }
            if(amount > WithDrawLimit)
            {
                throw new DepositException("Limite atingido!");
            }
            Balance -= amount;
        }
    }
}
