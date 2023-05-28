using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritOne.Entities
{
    internal class Account
    {
        public string Holder { get; protected set; }
        public int Number { get; protected set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }
        public Account(string holder, int number, double balance)
        {
            Holder = holder;
            Number = number;
            Balance = balance;
        }   
    }
}
