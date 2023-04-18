using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    internal class Funcionario
    {
        public int? _ID { get; set; }
        public string _Nome { get; set; }
        public double _Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            _ID = id;
            _Nome = nome;
            _Salario = salario;
        }
        public Funcionario()
        {

        }
        public Funcionario(int id)
        {
            _ID = id;
        }
        public void Aumento(int id, double x)
        {
            _ID = id;
            if (_ID == null)
            {
                Console.WriteLine("Identificador não existe");
            }
            else
            {
                x = x / 100;
                _Salario += _Salario * x;
            }


        }
        public override string ToString()
        {
            return +_ID + " ," + _Nome + " , " + "R$" + _Salario;
        }

    }
}
