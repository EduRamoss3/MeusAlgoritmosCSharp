using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSorcedEmployee.Entities
{
    internal class Employee
    {
        public string Name { get; set; }    
        public int Hours { get; set; }  
        public double valuePerHour { get; set; }

        
        public Employee()
        {

        }

        public Employee (string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            this.valuePerHour = valuePerHour;
        }   
       
        public virtual double Payment()
        {
            return Hours * valuePerHour;
        }
       
    }
}
