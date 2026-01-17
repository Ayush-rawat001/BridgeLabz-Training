using System;

namespace BookBuddy
{
    class InvalidBookFormatException : Exception
    {
        public InvalidBookFormatException(string message)
            : base(message)
        {
        }
    }
}
