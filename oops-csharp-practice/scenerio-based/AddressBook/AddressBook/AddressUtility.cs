using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.AddressBook
{
    class AddressUtility : IAddress
    {
        AddressBook[] Contacts = new AddressBook[50];
        int count = 0;

        public void AddContact()
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

            AddressBook contact = new AddressBook(firstName, lastName, email, phone, city, state, country, zip);

            Contacts[count] = contact;
            count++;

            Console.WriteLine("Address added successfully!");
        }

        public void EditContact()
        {

            if (count == 0)
            {
                Console.WriteLine("No contacts !");
                return;
            }

            Console.WriteLine("Which Contact you want to edit");

            Console.Write("Enter First Name :");

            string first = Console.ReadLine();

            Console.Write("Enter Last Name :");

            string last = Console.ReadLine();

            int idx = -1;

            for (int i = 0; i < count; i++)
            {
                if (Contacts[i].FirstName == first && Contacts[i].LastName == last)
                {
                    idx = i;
                    break;
                }

            }
            if (idx == -1)
            {
                Console.WriteLine("no contact of this name !");
                return;
            }

            while (true)
            {
                Console.WriteLine("press 1 to edit first name");
                Console.WriteLine("press 2 to edit last name");
                Console.WriteLine("press 3 to edit email");
                Console.WriteLine("press 4 to edit phone number");
                Console.WriteLine("press 5 to edit city");
                Console.WriteLine("press 6 to edit state");
                Console.WriteLine("press 7 to edit country");
                Console.WriteLine("press 8 to edit zip code");
                Console.WriteLine("press 9 to exit");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first name :");
                        Contacts[idx].FirstName = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter Last name :");
                        Contacts[idx].LastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter email :");
                        Contacts[idx].Email = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter Phone number :");
                        Contacts[idx].PhoneNumber = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Enter city :");
                        Contacts[idx].City = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter state :");
                        Contacts[idx].State = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Enter country :");
                        Contacts[idx].Country = Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Enter zipcode :");
                        Contacts[idx].ZipCode = Console.ReadLine();
                        break;
                    case 9:
                        return;
                }

            }
        }

        public void DisplayInfo()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts !");
                return;
            }
            Console.WriteLine("-------All the Contacts details---------\n");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Full Name : {Contacts[i].FirstName} {Contacts[i].LastName} " +
                    $"| Email: {Contacts[i].Email}| phone number: {Contacts[i].PhoneNumber} " +
                    $"| city: {Contacts[i].City} | state: {Contacts[i].State} | country: {Contacts[i].Country} " +
                    $"| zipcode: {Contacts[i].ZipCode}");
            }
        }
    }
}
