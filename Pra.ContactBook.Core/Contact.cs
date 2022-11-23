using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.Contacts.Core
{
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }

        public Contact(string name, string address, string telephoneNumber)
        {
            Name = name;
            Address = address;
            TelephoneNumber = telephoneNumber;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
