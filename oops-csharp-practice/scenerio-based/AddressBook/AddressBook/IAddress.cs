using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.AddressBook
{
    internal interface IAddress
    {
        public void AddContact();
        public void EditContact();
        public void DisplayInfo();
    }
}
