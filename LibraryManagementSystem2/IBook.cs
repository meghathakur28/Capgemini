using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    public interface IBook
    {
        int ID { get; }
        string Title { get; }
        string Author { get; }
        string Category { get; }
        int Price { get; }
        
        int Quantity { get; }
    }
}
