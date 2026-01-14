using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.AddressBook
{
     class AddressUtility:IAddress
    {
        AddressBook[] Books = new AddressBook[50];// array to store address
        int count = 0; //variable to store index

        public void AddAddress() // interface method implemented
        {
            Console.WriteLine("\n--- Enter Contact Details ---");

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Country: ");
            string country = Console.ReadLine();

            Console.Write("Zip Code: ");
            string zip = Console.ReadLine();

            AddressBook addressbook = new AddressBook(firstName, lastName, email, phone, city, state, country, zip); // calling constructor of AddressBook

            Books[count] = addressbook; // adding address inside constructor
            count++; // increment of counter/index

            Console.WriteLine("Address added successfully!");
        }
    }
}
