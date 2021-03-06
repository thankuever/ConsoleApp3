﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar bar = new Bar();
            //價格
            Money beerPrice = 800;
            Money winePrice = 500;
            Money whiskyPrice = 890;
            //Money xx = -100;

            //酒
            Liquor beer = new Liquor("啤酒", beerPrice);
            Liquor wine = new Liquor("紅酒", winePrice);
            Liquor whisky = new Liquor("威士忌", whiskyPrice);

            //顧客
            Customer c1 = new Customer("Allen","rfg@yahoo.com.tw");
            Customer c2 = new Customer("Hui","rwt@yahoo.com.tw");
            Customer c3 = new Customer("Danny","regtrege@gmail.com");
           // Customer c4 = new Customer("Danny", "regtrege");


            //訂單
            Order order1 = new Order(1, new List<OrderItem>() {
                new OrderItem(beer,23),
                new OrderItem(wine,2),
                new OrderItem(whisky,2)
            });
            Order order2 = new Order(1, new List<OrderItem>() {
                new OrderItem(beer,10),
                new OrderItem(wine,2)
            });
            Order order3 = new Order(1,new List<OrderItem>() {
                new OrderItem(beer,2),
                new OrderItem(wine,99),
                new OrderItem(whisky,100)
            });

            //顧客下訂單
            c1.Create(bar, order1);
            c2.Create(bar, order2);
            c3.Create(bar, order3);

            //印出銷售明細
            Console.WriteLine("銷售明細".YH_JumpLine());
            Console.WriteLine("Bar總銷售額"+bar.printRecord()+"".YH_JumpLine());
            Console.WriteLine("-------------------------------------------");

            //印出各類酒銷售數量
            Console.WriteLine("銷售瓶數".YH_JumpLine());
            Console.WriteLine("啤酒:" + beer.SaleQty +"瓶".YH_JumpLine());
            Console.WriteLine("威士:" + whisky.SaleQty+ "瓶".YH_JumpLine());
            Console.WriteLine("紅酒:" + wine.SaleQty + "瓶".YH_JumpLine());

            Console.ReadLine();
        }
    }
}

    