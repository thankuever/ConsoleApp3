using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public struct Email
    {
        public string value { get; private set; }
        public Email(string email)
        {
            this.value = email;
        }

        public static implicit operator String (Email email)
        {
            if (email.value.IsValidEmail())
            {
                return email.ToString();
            }
            else
            {
                throw new Exception(nameof(email));
            }
        }

        public static implicit operator Email (String email)
        {
            return new Email(email);
        }

    }
}
