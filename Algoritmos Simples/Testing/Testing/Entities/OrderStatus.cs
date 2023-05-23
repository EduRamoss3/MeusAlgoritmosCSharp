using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Entities
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,  
    }
}
