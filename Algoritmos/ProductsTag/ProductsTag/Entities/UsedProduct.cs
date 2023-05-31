using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsTag.Entities;
using ProductsTag.Entities.Enums;

namespace ProductsTag.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; } = new DateTime();
        
        public UsedProduct()
        {

        }
        public UsedProduct(string name, double price, DateTime date, Types type) : base (name, price, type)
        {
            this.manufactureDate = date;

        }
        public UsedProduct(DateTime manufactureDate)
        {
            this.manufactureDate = manufactureDate;
        }


        public override string priceTag()
        {
            return Name
                +"$"+ Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + manufactureDate.ToString("dd/MM/yyyy")
                + ")" + " Type: (" + Type + ")";
        }
    }
}
