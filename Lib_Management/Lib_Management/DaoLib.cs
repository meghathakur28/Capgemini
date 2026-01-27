using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lib_Management
{
    public class DaoLib:IAdmin, IUser
    {
        public static List<Book> books = new List<Book> ();

        public bool Add(Book book)
        {
            if (book != null)
            {
                books.Add (book);
                return true;
            }
            throw new LibraryException("There is no Book data");
        }

        public void BrowseBooks()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            Book book = books.Find(x=>x.BookID == id);
            if (book != null)
            {
                books.Remove(book);

                return true;
            }
            throw new LibraryException("There is no book with this id");
        }

        public Book HighestPriceBook()
        {
            int max = books.Max(x => x.Price);
            Book book = books.Find(x=>x.Price == max);
            return book;
        }

        public Book LowestPriceBook()
        {
            int min = books.Min(x => x.Price);
            Book book = books.Find(x => x.Price == min);
            return book;
        }

        public Book SearchBookByname(string name)
        {
            Book book = books.Find(x => x.Title == name);
            if (book != null)
            {
                return book;
            }
            throw new LibraryException("Thre is no book with this title");
        }

        public Book SearchBookByPublisher(string publisher)
        {
            Book book = books.Find(x => x.Publisher == publisher);
            if (book != null)
            {
                return book;
            }
            throw new LibraryException("Thre is no book with this publisher");
        }

        public bool Update(int id, Book UpdatedBook)
        {
            Book book = books.Find(x => x.BookID == id);
            if (book != null)
            {
                book = UpdatedBook;
                return true;
            }
            throw new LibraryException("There is no book with this id");
        }

        public void ViewAllBooks()
        {
            foreach(var i in  books)
            {
                Console.WriteLine(i.Title+" "+i.Publisher+" "+i.Author);
            }
        }
    }
}
