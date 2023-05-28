using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSorcedEmployee.Entities
{
    sealed class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }
        public OutsourcedEmployee(string name, int hours , double valueperhour, double additionalCharge) : base (name,hours, valueperhour)
        {
            this.AdditionalCharge = additionalCharge;

        }
        public sealed override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
