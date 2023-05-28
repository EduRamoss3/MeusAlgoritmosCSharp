using Inherit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UP CASTING
            Account acc1 = new Account("Eduardo", 139203, 10000, "Account");
            Account acc2 = new SavingsAccount("Regina", 12345, 10000, "Savings Account");
            
            Account bss1 = new BusinessAccount("Mai", 12543, 10000,500, "Business Account");
            //DOWN CASTING
            BusinessAccount bss4 = (BusinessAccount)bss1;
            acc1.WithDraw(250);
            acc2.WithDraw(250);
            bss1.WithDraw(250);           


            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2.ToString());
            Console.WriteLine(bss1.ToString());
            Console.ReadKey();

        }
    }
}
