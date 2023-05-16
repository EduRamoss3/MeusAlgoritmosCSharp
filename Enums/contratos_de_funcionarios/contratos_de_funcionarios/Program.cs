using contratos_de_funcionarios.Entities;
using contratos_de_funcionarios.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace contratos_de_funcionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Level Junior / MidLevel / Senior :");

            WorkerLevel workerlevel = new WorkerLevel();

            Enum.TryParse(Console.ReadLine(), out workerlevel);
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Departmente dept = new Departmente(deptName);
            Worker worker = new Worker(name, workerlevel, baseSalary, dept);

            Console.WriteLine("How many contract's you have?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter the date of #{i} contract:");

                Console.WriteLine("Date  (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.WriteLine("Duration(hours):");
                int hours = int.Parse(Console.ReadLine());


                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            worker.Income(year, month);
            worker.Year = year;
            worker.Month = month;
            worker.ToString();


        }
    }
}
