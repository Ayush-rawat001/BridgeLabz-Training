using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AddressBook.AddressBook
{
    internal class AddressBookMenu
    {
        public void Run() //method to show the Menu
        {
            AddressUtility addressUtility = new AddressUtility(); // object of utility to call the method
            while(true)
            {
                Console.WriteLine("Press 1 to Add Address book");
                Console.WriteLine("Press 2 to Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        addressUtility.AddAddress();
                        break;
                    case 2:
                        return;
                }
            }
            
        }
    }
}
