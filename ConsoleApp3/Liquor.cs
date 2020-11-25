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

        public int SaleQty
        {
            get;set;
        }

        //建構子
        public Liquor(string name, Money price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
    

