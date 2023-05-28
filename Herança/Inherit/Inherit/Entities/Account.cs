using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Inherit.Entities
{
    internal class Account
    {
        public string Holder { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public string TypeAccount { get; set; } 

        public Account()
        {

        }
        public Account(string holder, int accountNumber, double balance , string type)
        {
            TypeAccount = type;
            Holder = holder;
            AccountNumber = accountNumber;
            Balance = balance;
        }   
        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5.0;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Holder Account: " + Holder);
            sb.AppendLine("Account type: " + TypeAccount);
            sb.AppendLine("Account Number: " + AccountNumber);
            sb.AppendLine("Account Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }
    }
}
