using System;
using Microsoft.VisualBasic;
using MovieLibrary;
namespace MovieApp
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Welcome to the Film Library!");
            Console.WriteLine("1. Add Film");
            Console.WriteLine("2. Remove Film");
            Console.WriteLine("3. Get Films");
            Console.WriteLine("4. Search Films ");
            Console.WriteLine("5. Get Total Count");
            Console.WriteLine("6. Exit");
        }
        static void Main(string[] args)
        {
            FilmLibrary filmlb = new FilmLibrary();
            int choice = 0;
            while (choice != 6)
            {
                Menu();
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Film flim = new Film();
                            Console.Write("Enter Film Title: ");
                            string title = Console.ReadLine();
                            flim.Title = title;
                            Console.Write("Enter Film Director: ");
                            string director = Console.ReadLine();
                            flim.Director = director;
                            Console.Write("Enter the year: ");
                            int year = Convert.ToInt32(Console.ReadLine());
                            flim.Year = year;
                            try
                            {

                                bool ans = filmlb.AddFilm(flim);
                                if(ans)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Film added Successfully");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Film is not added in the List");
                                    Console.ResetColor();
                                }
                            }
                            catch (FilmException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter Film Title to Remove: ");
                            string removeTitle = Console.ReadLine();
                            try
                            {
                                bool ans = filmlb.RemoveFilm(removeTitle);
                                if(ans)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Film removed Successfully");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Film is not removed from the List");
                                    Console.ResetColor();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                filmlb.GetFilm();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter search term: ");
                            string searchTerm = Console.ReadLine();
                            IFilm searchResults = filmlb.SearchFilms(searchTerm);
                            try
                            {
                                Console.ForegroundColor= ConsoleColor.Magenta;
                                Console.WriteLine($"Title: {searchResults.Title}, Director: {searchResults.Director}, Year: {searchResults.Year}");
                                Console.ResetColor();
                            }
                            catch (FilmException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    case 5:
                        {
                            try
                            {
                                int count = filmlb.GetTotalFilmCount();
                                if (count > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine($"Total Films: {count}");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("There is no film in the list. The count is 0"); 
                                    Console.ResetColor();
                                }
                            }
                            catch(Exception e)

                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Exiting...");
                            Console.WriteLine("Thankyou for using the Movie Library Mangement System");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                        }
                }
            }
        }
    }
}
