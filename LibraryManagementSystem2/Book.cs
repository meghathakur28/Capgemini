using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    public class Book : IBook
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}
