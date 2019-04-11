using System;
using System.Collections.Generic;

namespace myApp
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public void print() {
            Console.WriteLine($@"
Contact: {FirstName} {LastName}
Email: {Email}
Address: {Address}

            ");
        }


    }
}