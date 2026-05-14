using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Movie
{
    class InvalidTimeFormatException : Exception
    {
        public InvalidTimeFormatException(string message)
            : base(message)
        {
        }
    }
}

