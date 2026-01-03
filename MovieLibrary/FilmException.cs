using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary
{
    public class FilmException:Exception
    {
        public FilmException() { }
        public FilmException(string message) : base(message)
        {
        }
    }
}
