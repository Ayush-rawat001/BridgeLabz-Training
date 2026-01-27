using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
//3.Library Management System – Book Search and Checkout
//Scenario: You’re designing a system for a small library to manage books and track checkouts.
//Problem Requirements:
//● Store book details (title, author, status) in a Array.
//● Allow searching by partial title using String operations.
//● Store book data in an Array.
//● Use methods for searching, displaying, and updating book status (checked out or
//available).

using System;

namespace LibManagementSystem.LibManagementSystem
{
    class Book
    {
        private string title;
        private string author;
        private string status;

        public Book(string title, string author, string status)
        {
            this.title = title;
            this.author = author;
            this.status = status;
        }

       
        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetStatus()
        {
            return status;
        }

        
        public void SetStatus(string status)
        {
            this.status = status;
        }
    }
}
