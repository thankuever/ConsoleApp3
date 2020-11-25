using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Bar
    {
        //所有點單
        public List<Order> Orders = new List<Order> { };

        //銷售額
        private Money _revenue = new Money(0);

        public Money Revenue
        {
            get
            {
                return _revenue;
            }

            private set { 
            }
        }
    
    public int printRecord()
    {
        foreach (Order o in Orders)
        {
             
            foreach (OrderItem item in o.Items)
            {
                item.Liquor._SaleQty += item._Qty;
                int price = Convert.ToInt32(item.Liquor.Price.Value);
                int qty = item._Qty;
                Console.WriteLine("向"+o.CustmerName +"銷售" + item.Liquor.Name + qty + "瓶".YH_JumpLine());
                Revenue.Value += price * qty;
            }
        }
            return Revenue.Value;
    }
}
}
