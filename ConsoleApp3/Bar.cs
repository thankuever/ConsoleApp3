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
        private Money _revenue = 0;
    
    public int printRecord()
    {
        foreach (Order o in Orders)
        {         
            foreach (OrderItem item in o.Items)
            {
                item.Liquor.SaleQty += item.Qty;
                int price = Convert.ToInt32(item.Liquor.Price.Value);
                int qty = item.Qty;
                Console.WriteLine("向"+o.CustmerName +"銷售" + item.Liquor.Name + qty + "瓶".YH_JumpLine());
                _revenue += price * qty;
            }
        }
            return _revenue.Value;
    }
}
}
