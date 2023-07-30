using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int QntFunc { get; set; }
        public PessoaJuridica(int qntFunc, string name, double annual): base (name, annual)
        {
            QntFunc = qntFunc;
        }
        public override double Taxes()
        {
           if(QntFunc > 10)
           {
                double TaxesValue = Annual * 1.4 / 10;
                return TaxesValue;
 
           }
           else
           {
                double TaxesValue = Annual * 1.6 / 10;
                return TaxesValue;
           }
        }
    }
}
