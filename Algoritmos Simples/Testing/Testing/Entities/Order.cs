using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client client { get; set; }
        
        public Order()
        {

        }
       
    
        public Order(DateTime moment, OrderStatus status, Client cclient)
        {
            Moment = moment;
            Status = status;
            client = cclient;
        }
    
        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;

            foreach(OrderItem item in Items)
            {
                sum += item.subTotal(item.Quantity, item.Price); 
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + client.ToString());
            sb.AppendLine("Order items: ");
                foreach (OrderItem Item in Items)
                {
                sb.AppendLine(Item.ToString());
                }
            sb.AppendLine("Total price: $" + Total().ToString("F2",CultureInfo.InvariantCulture));
                
            
            
            return sb.ToString();
        }


    }
}
