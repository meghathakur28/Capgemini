using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_Management
{
    public class LibraryException:Exception
    {
        public LibraryException() { }
        public LibraryException(string message) : base(message) { }
    }
}
