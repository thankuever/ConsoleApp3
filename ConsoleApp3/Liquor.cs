using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //酒類別 (Value Object 值物件)
    class Liquor
    {
        //Property: 酒名
        public string Name { get; set; }

        //Property: 價格
        public Money Price { get; set; }
        private int saleQty = 0;

        public int _SaleQty
        {
            get { return saleQty; }
            set { 
                if(value>0)
                {
                    saleQty = value;
                }
                else
                {
                    saleQty = 0;
                }
                        }
        }

        //建構子
        public Liquor(string name, Money price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
    

