using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Globalization;


internal class Program
{
    static void Main(string[] args)
    {
        DateTime time = new DateTime(2018, 11, 25);
        DateTime start = DateTime.Now;
        DateTime end = DateTime.ParseExact("04-03-2023 12:04:33", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        Console.WriteLine(time);
        Console.WriteLine(start);
        Console.WriteLine(end);
    }
}
