using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Exceptions
{
    internal class DepositException : ApplicationException
    {
        public DepositException(string message) : base(message)
        {
           
        }
    }
}
