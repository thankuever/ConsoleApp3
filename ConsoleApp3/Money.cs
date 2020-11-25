using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   public class Money
    {
        public Money(int Value)
        {
            _value = Value;
        }

        private int _value;
        public int Value
        {
            set
            {             
                //金額需大於等於0
                if (value >= 0)
                {
                    _value = value;
                }
                else
                {
                    _value = 0;
                }
            }
            get
            {
                return _value;
            }
        }

    }
}
