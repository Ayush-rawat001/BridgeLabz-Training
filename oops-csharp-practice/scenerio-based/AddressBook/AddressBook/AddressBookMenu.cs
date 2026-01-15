using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AddressBook.AddressBook
{
    internal class AddressBookMenu
    {
        public void Run()
        {
            AddressUtility addressUtility = new AddressUtility();
            while(true)
            {
                Console.WriteLine("Press 1 to Add Contact in Address Book");
                Console.WriteLine("Press 2 to Edit Contact in Address book");
                Console.WriteLine("Press 2 to Display Contact in Address book");
                Console.WriteLine("Press 4 to Exit");

                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        addressUtility.AddContact();
                        break;
                    case 2:
                        addressUtility.EditContact();
                        break;
                    case 3:
                        addressUtility.DisplayInfo();
                        break;
                    case 4:
                        break;
                }
            }
            
        }
    }
}
