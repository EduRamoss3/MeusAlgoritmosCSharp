using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrubuDoPix.Entities
{
    internal class Resume
    {
        public List<Transaction> Changes { get; set; } = new List<Transaction>();

        public Resume()
        {

        }
        public Resume(List<Transaction> changes)
        {
            Changes = changes;
        }   

        public void addChanges(Transaction transaction)
        {
            Changes.Add(transaction);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Transaction t in Changes)
            {
                sb.AppendLine("User:" + t._user.Name);
                sb.AppendLine("Balance: " + t.Balance.ToString("F2"));
               foreach(DateTime s in  t.Dates)
                {
                    sb.AppendLine("Data de transação: " +s.ToString("dd/MM/yyyy hh:mm:ss") + " Tipo de transação: " + t.Type);

                }
            }   
            
            return sb.ToString();
        }
    }
}
