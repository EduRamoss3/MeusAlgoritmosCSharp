using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace UrubuDoPix.Entities
{
    internal class Transaction
    {
        public double Balance { get; protected set; }
        public User _user { get; set; }

        public List<DateTime> Dates { get; set; } = new List<DateTime>();
        public string Type { get; set; }
        public Transaction(User user)
        {
            _user = user;
        }
        public Transaction(User user,DateTime datetime){

            _user = user;
            Dates.Add(datetime);

        }
        public void Profit(DateTime timer)
        {
            if (DateTime.Now.Hour == 00) {
                Type = "Juros";
                Balance += Balance * (33.33 / 100.00);
                Console.WriteLine("O Juros de 33% foi adicionado.");
            }
            else 
            {
                Console.WriteLine("O juros de 33% será adicionado a meia noite.");
            }
        }
        public void withDraw(double amount)
        {
            Type = "Saque";
            Dates.Add(DateTime.Now);
            Balance -= amount;
           
        }
        public void Deposit(double amount)
        {
            Type = "Deposito";
            Balance += amount;
            Dates.Add(DateTime.Now);
        }
       
      
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RESUME");
            
            return sb.ToString();
        }


    }
}
