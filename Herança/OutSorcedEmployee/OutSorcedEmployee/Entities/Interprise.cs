using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OutSorcedEmployee.Entities
{
    internal class Interprise : Employee
    {
        public List<Employee> Employers = new List<Employee>();

        public Interprise()
        {

        }
        public void AddEmployee(Employee employee)
        {
            Employers.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            Employers.Remove(employee);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in Employers)
            {
               sb.AppendLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
          
            return sb.ToString();
        }
    }
}
