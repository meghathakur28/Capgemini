using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    public class LibrarySystem : ILibrarySystem
    {
        private Dictionary<IBook, int> booksInventory = new Dictionary<IBook, int>();
        public void AddBook(IBook book, int quantity)
        {
            if(booksInventory.ContainsKey(book))
            {
                booksInventory[book] += quantity;
            }
            else
            {
                booksInventory[book] = quantity;
            }
        }

        public List<(string, int, int)> BooksInfo()
        {
            List<(string, int, int)> booksInfo = new List<(string, int, int)>();
            foreach(var b in booksInventory)
            {
                booksInfo.Add((b.Key.Title, b.Value, b.Key.Price));
            }
            return booksInfo;
        }

        public int CalculateTotal()
        {
            int total = 0;
            foreach(var b in booksInventory)
            {
                total += b.Key.Price * b.Value;
            }
            return total;
        }

        public List<(string, int)> CategoryTotalPrice()
        {
            List<(string, int)> categoryTotals = new List<(string, int)>();

            foreach(var  b in booksInventory)
            {
                if(categoryTotals.Exists(ct => ct.Item1 == b.Key.Category))
                {
                    int index = categoryTotals.FindIndex(ct => ct.Item1 == b.Key.Category);
                    var existing = categoryTotals[index];
                    categoryTotals[index] = (existing.Item1, existing.Item2 + (b.Key.Price * b.Value));
                }
                else
                categoryTotals.Add((b.Key.Category, b.Key.Price * b.Value));

            }
            return categoryTotals;
        }

        public List<(string, string, int)> CategoryAndAuthorWithCount()
        {
            List<(string, string, int)> categoryAuthorCounts = new List<(string, string, int)>();
            foreach(var b in booksInventory)
            {
                if(categoryAuthorCounts.Exists(ca=> ca.Item1 == b.Key.Category && ca.Item2 == b.Key.Author))
                {
                    int index = categoryAuthorCounts.FindIndex(ca => ca.Item1 == b.Key.Category && ca.Item2 == b.Key.Author);
                    var existing = categoryAuthorCounts[index];
                    categoryAuthorCounts[index] = (existing.Item1, existing.Item2, existing.Item3 + b.Value);
                }
                else
                categoryAuthorCounts.Add((b.Key.Category, b.Key.Author, b.Value));
            }
            return categoryAuthorCounts;
        }

        public void RemoveBook(IBook book, int quantity)
        {
            if(booksInventory.ContainsKey(book))
            {
                booksInventory[book] -= quantity;
                if (booksInventory[book] <= 0)
                {
                    booksInventory.Remove(book);
                }
            }
        }
    }
}
