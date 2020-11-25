using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Customer
    {
        private string email;

        public string _Email
        {
            set
            {
                if(value.IsValidEmail())
                {
                    email = value;
                }
                else
                {
                    email = "wrong format";
                }
            }
            get
            {
                return _Email;
            }
        }

        public String Name { get; set; }

        public Customer(String name)
        {
            this.Name = name;
        }

        public void Create(Bar bar ,Order o)
        {
           o.CustmerName = Name;
           bar.Orders.Add(o);
        }

    }
}

