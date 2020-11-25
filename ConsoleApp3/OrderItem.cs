using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class OrderItem
    {   
        public Liquor Liquor { get; set; }
        public int Qty
        {
            get;
            set;
        }

        public OrderItem(Liquor liquor,int qty)
        {
            this.Liquor = liquor;
            this.Qty = qty;
        }
    }
}
