using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Customer
    {

        public string Email
        {
            get;private set;     
        }

        public String Name { get; set; }

        public Customer(String name,Email email)
        {
            this.Name = name;
            this.Email = email;
        }

        public void Create(Bar bar ,Order o)
        {
           o.CustmerName = Name;
           bar.Orders.Add(o);
        }

    }
}

