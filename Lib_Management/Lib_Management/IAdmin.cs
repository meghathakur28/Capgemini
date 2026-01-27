using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_Management
{
    public interface IAdmin
    {
        public bool Add(Book book);

        public bool Update(int id, Book UpdatedBook);

        public bool Delete(int id);

        public void ViewAllBooks();

    }
}
