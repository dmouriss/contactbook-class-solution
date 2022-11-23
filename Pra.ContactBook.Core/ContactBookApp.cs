using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.Contacts.Core
{
    public class ContactBookApp
    {

        private int numberOfBooks;
        public List<ContactBook> Contactbooks { get; } = new List<ContactBook>();

        public void AddContactBook(string name)
        {
            ContactBook cb = new ContactBook(name);
            Contactbooks.Add(cb);
        }

        public void AddContactToContactBook(ContactBook cb, string name, string address, string telephoneNumber)
        {
            Contact c = new Contact(name, address, telephoneNumber);
            cb.AddContact(c);
        }

        public int NumberOfBooks()
        {
            return numberOfBooks;
        }
    
    }
}
