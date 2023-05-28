using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; protected set; }
        public double BalanceLoan { get; protected set; }

        public BusinessAccount()
        {

        }
        public BusinessAccount(string holder, int accountNumber, double balance, double loanLimit , string type) : base( holder,  accountNumber, balance , type)
        {
            LoanLimit = loanLimit;
        }
      
        public void SetLoan(double loan)
        {
            if(LoanLimit < loan)
            {
                Balance += loan;
                BalanceLoan += loan;
            }
        }
        public sealed override void WithDraw(double amount)
        {
            Balance -= amount + 3.0;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Holder Account: " + Holder);
            sb.AppendLine("Account type: " + TypeAccount);
            sb.AppendLine("Account Number: " + AccountNumber);
            sb.AppendLine("Account Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Balance Loan value: " + BalanceLoan.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
