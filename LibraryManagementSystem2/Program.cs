using System;
using LibraryManagementSystem;

public class Program
{
    public static void Main(string[] args)
    {
        LibrarySystem libraryObj = new LibrarySystem();
        Console.WriteLine("Enter the number of books");
        int n = Int32.Parse(Console.ReadLine());
        Book[] books = new Book[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the Details of book " + (i + 1));
            books[i] = new Book();
            Console.Write("ID - ");
            books[i].ID = Int32.Parse(Console.ReadLine());

            Console.Write("Title - ");
            books[i].Title = Console.ReadLine();

            Console.Write("Author - ");
            books[i].Author = Console.ReadLine();

            Console.Write("Category - ");
            books[i].Category = Console.ReadLine();

            Console.Write("Price - ");
            books[i].Price = Int32.Parse(Console.ReadLine());

            Console.Write("Quantity - ");
            books[i].Quantity = Int32.Parse(Console.ReadLine());
            libraryObj.AddBook(books[i], books[i].Quantity);
        }

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Book Info: ");
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("Book Name: " + books[i].Title+ ", Quantity: " + books[i].Quantity + ", Price: " + books[i].Price);
        }
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Category Total Price: ");
        List<(string, int)> catTotal = libraryObj.CategoryTotalPrice();

        foreach(var t in catTotal)
        {
            Console.WriteLine("Category: " + t.Item1 + ", Total Price: " + t.Item2);
        }
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        List<(string, string, int)> catAuthor = libraryObj.CategoryAndAuthorWithCount();

        foreach (var t in catAuthor)
        {
            Console.WriteLine("Category: " + t.Item1 + ", Author: " + t.Item2+", Count: "+t.Item3);
        }
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(libraryObj.CalculateTotal());
        Console.ResetColor();


    }
}
