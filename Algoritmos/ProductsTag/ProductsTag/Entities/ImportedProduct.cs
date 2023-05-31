using ProductsTag.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTag.Entities
{
    internal class ImportedProduct : Product

    {
        public double _customFee { get; set; }  
        public ImportedProduct()
        {

        }
        public ImportedProduct(string name, double price, double customFee, Types type) : base(name, price, type)
        {
            Type = type;
            _customFee = customFee; 
            Name = name;
            Price = price;
        }
        public double totalPrice()
        {
            return Price + _customFee;
        }

        public override string priceTag()
        {
            return Name
                + " $"
                + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $"
                + _customFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")"+
                " Type: (" +Type+")";
        }
    }
}
