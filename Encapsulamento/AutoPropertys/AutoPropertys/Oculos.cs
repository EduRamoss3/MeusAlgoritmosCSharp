using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AutoPropertys
{
    internal class Oculos
    {
        private string _nome;
        public double Preco { get; set; }
        public int Quantidade { get; set; }


        public Oculos()
        {

        }

        public Oculos(string nome, int quantidade)
        {
            _nome = nome;
            Quantidade = quantidade;
        }

        public Oculos(string nome, int quantidade, double preco) : this(nome, quantidade)
        {
            Preco = preco;
        }

        public string Nome{
             get { return _nome; }
             set { 
                
                if(value != null && value.Length > 1)
                {
                    value = _nome;
                }
                else
                {
                    Console.WriteLine("Nome inválido.");
                }
                
               }

         }

    }
}
