using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Path.Entities
{
    internal class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Nome = vect[0];
            Salario = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }
        public int CompareTo(object obj)
        {
            if(!(obj is Funcionario))
            {
                throw new ArgumentException("Comparing error!");
            }
            Funcionario funcionario = obj as Funcionario;

            return Nome.CompareTo(funcionario.Nome);

        }
        public override string ToString()
        {
            return "Nome: " + Nome + " , Salario: " + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
