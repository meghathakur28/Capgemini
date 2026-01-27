using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_Management
{
    public interface IUser
    {
        public void BrowseBooks();
        public Book SearchBookByname(string name);

        public Book SearchBookByPublisher(string publisher);

        public Book HighestPriceBook();

        public Book LowestPriceBook();

    }
}
