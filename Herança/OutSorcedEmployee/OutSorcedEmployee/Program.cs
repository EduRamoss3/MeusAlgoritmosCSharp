using OutSorcedEmployee.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OutSorcedEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int num = int.Parse(Console.ReadLine());
            Interprise interprise = new Interprise();
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i+1} data:");
                Console.WriteLine("Outsourced (y/n)?");
                char character = char.Parse(Console.ReadLine());

                switch (character)
                {
                    case 'y':
                        {
                            Console.Write("Name: ");
                            string outSorcedName = Console.ReadLine();
                            Console.Write("Hours: ");
                            int outSorcedHours = int.Parse(Console.ReadLine());
                            Console.Write("Value per hour: ");
                            double outSorcedValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                            Console.Write("Additional charge: ");
                            double outSorcedAdditional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            OutsourcedEmployee outemployee = new OutsourcedEmployee(outSorcedName,outSorcedHours,outSorcedValue,outSorcedAdditional);
                            interprise.AddEmployee(outemployee);

                            break;
                        }
                    case 'n':
                        {
                            Console.Write("Name: ");
                            string employeeName = Console.ReadLine();
                            Console.Write("Hours: ");
                            int employeeHours = int.Parse(Console.ReadLine());
                            Console.Write("Value per hour: ");
                            double employeeValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Employee employe = new Employee(employeeName, employeeHours, employeeValue);
                            interprise.AddEmployee(employe);

                            break;
                            
                        }
                      
                }
                
               
            }
            Console.WriteLine("\n\t\tPAYMENTS:");
            Console.WriteLine(interprise);
            Console.ReadKey();

        }
    }
}
