using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Bancaria
{
    internal class Pessoa
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }   
        public Pessoa(int numero,string nome)
        {
            Numero = numero;
            Nome = nome;
        }
        public Pessoa(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }
        public override string ToString()
        {
            return "Conta" +
                   Numero +
                   ", Titular>: " +
                   Nome +
                   ", Saldo R$" +
                   Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }

}
