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
        private int qty = 0;
        public int _Qty { 
            get {
                return qty;
            }
            set {
                if (value > 1)
                {
                    qty = value;
                }
            } }

        public OrderItem(Liquor liquor,int qty)
        {
            this.Liquor = liquor;
            this._Qty = qty;
        }
    }
}
