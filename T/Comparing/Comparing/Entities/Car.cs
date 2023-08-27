using Comparing.CarProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing.Entities
{
    public class Car : CarPropertys
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public bool Clean { get; set; }
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return "Model: " + Model + " , Year: " + Year;
        }

    }
}
