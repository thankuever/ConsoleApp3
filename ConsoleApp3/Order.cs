using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //點單
    class Order
    {  
        //點單編號
        public int OrderId;

        public String CustmerName;

        //點單細項
        public List<OrderItem> Items;


        public Order(int orderId,List<OrderItem> items)
        {
            this.OrderId = orderId;
            this.Items = items;
        }

    }
}
