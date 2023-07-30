using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double IncomeHealth { get; set; }
        public PessoaFisica(double incomeHealth, string name, double annual) : base (name, annual)
        {
            IncomeHealth = incomeHealth;
        }

        public override double Taxes()
        {
            if(Annual < 20000.00)
            {
                double TaxesValue = (Annual * 1.5) / 10;
                if(IncomeHealth > 0)
                {
                    double impostHealth = IncomeHealth / 2;
                    return TaxesValue - impostHealth;
                }
                else
                {
                    return TaxesValue;
                }
            

            }
            else
            {
                double TaxesValue = (Annual * 2.5) / 10;
                if (IncomeHealth > 0)
                {
                    double impostHealth = IncomeHealth / 2;
                    return TaxesValue - impostHealth;
                }
                else
                {
                    return TaxesValue;
                }
            }
        }
    }
}
