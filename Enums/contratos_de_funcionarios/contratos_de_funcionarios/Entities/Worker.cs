using contratos_de_funcionarios.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace contratos_de_funcionarios.Entities
{
    internal class Worker
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departmente Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker()
        {

        }
        public Worker(string name, WorkerLevel level, double baseSalary, Departmente department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            
        }
    
        public void AddContract(HourContract contract )
        {
            Contracts.Add(contract);   
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year , int month)
        {
            
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;  
        }
        public override string ToString()
        {
            return "Name:\n" + Name +
                   "Department: \n" + Department.Name +
                   "Income for" + Year + "/" + Month;
                   
        }
    }
}
