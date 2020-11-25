using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public struct Money
    {

        public int Value { get; private set; }
        private Money(int money)
        {
            this.Value = money;
        }
        public static implicit operator Money (int money)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Money));
            }
            else
            {
                return new Money(money);
            }
        }

        public static implicit operator int (Money money)
        {
            return money.Value;
        }

    }
}