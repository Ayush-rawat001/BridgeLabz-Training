using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.AddressBook
{
     class AddressBookMain
    {
        static void Main()
        {
            Console.WriteLine("---------Welcome to Address Book Program---------\n"); 
            AddressBookMenu addressBookMenu = new AddressBookMenu(); // AddressBookMenu object to execute Run method;
            addressBookMenu.Run();

        }
    }
}
