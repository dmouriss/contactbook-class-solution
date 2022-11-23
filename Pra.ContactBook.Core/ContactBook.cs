using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.Contacts.Core
{
    public class ContactBook
    {

        public List<Contact> Contacts { get; }
        public string Name { get; }

        public ContactBook(string name)
        {
            Name = name;
            Contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
