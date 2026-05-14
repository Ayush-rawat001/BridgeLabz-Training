using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.AddressBook
{
    class AddressBook
    {
        private string _LastName;
        private string _FirstName;
        private string _Email;
        private string _PhoneNumber;
        private string _City;
        private string _Country;
        private string _ZipCode;
        private string _State;

        // Getter and Setter for FirstName
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        // Getter and Setter for LastName
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        // Getter and Setter for Email
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        // Getter and Setter for PhoneNumber
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }

        // Getter and Setter for City
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        // Getter and Setter for Country
        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        // Getter and Setter for ZipCode
        public string ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }

        // Getter and Setter for State
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        
        //constructor of AddressBook
        public AddressBook(string firstName, string lastName, string email,string phoneNumber, string city, string state,string country, string zipCode)
        {
            _FirstName = firstName;
            _LastName = lastName;
            _Email = email;
            _PhoneNumber = phoneNumber;
            _City = city;
            _State = state;
            _Country = country;
            _ZipCode = zipCode;
        }

    }

}

