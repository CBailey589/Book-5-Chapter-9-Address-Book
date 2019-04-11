using System;
using System.Collections.Generic;

namespace myApp
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts { get; set; } = new Dictionary<string, Contact>();

        public void AddContact(Contact contact){
            Contacts[contact.Email] = contact;
            // Contacts.Add(contact.Email, contact)
        }

        public Contact GetByEmail(string email){
            return Contacts[email];
        }
    }
}