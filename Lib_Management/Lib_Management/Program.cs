using System;
namespace Lib_Management
{
    public class Program
    {
        public static void Actors()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit");
            Console.ResetColor();
        }
        public static void AdminMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. View All Book");
            Console.WriteLine("5. Exit");
            Console.ResetColor();
        }

        public static void UserMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Browse Books");
            Console.WriteLine("2. Search Book by Name");
            Console.WriteLine("3. Search Book by Publisher");
            Console.WriteLine("4. View Highest Price Book");
            Console.WriteLine("5. View Lowest Price Book");
            Console.WriteLine("6. Exit");
            Console.ResetColor();
        }

        public static void Main(string[] args)
        {
            int choiceActor = 0;
            while (choiceActor != 3)
            {
                Actors();
                Console.WriteLine("Enter your choice: ");
                choiceActor = Int32.Parse(Console.ReadLine());
                switch (choiceActor)
                {
                    case 1:
                        {
                            int adminMenu = 0;
                            while (adminMenu != 5)
                            {
                                AdminMenu();
                                Console.WriteLine("Enter your choice: ");
                                adminMenu = Int32.Parse(Console.ReadLine());
                                switch (adminMenu)
                                {
                                    case 1:
                                        {
                                            break;
                                        }
                                    case 2:
                                        {
                                            break;
                                        }
                                    case 3:
                                        {
                                            break;
                                        }
                                    case 4:
                                        {
                                            break;
                                        }
                                    case 5:
                                        {
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            int adminMenu = 0;
                            while (adminMenu != 5)
                            {
                                AdminMenu();
                                Console.WriteLine("Enter your choice: ");
                                adminMenu = Int32.Parse(Console.ReadLine());
                                switch (adminMenu)
                                {
                                    case 1:
                                        {
                                            break;
                                        }
                                    case 2:
                                        {
                                            break;
                                        }
                                    case 3:
                                        {
                                            break;
                                        }
                                    case 4:
                                        {
                                            break;
                                        }
                                    case 5:
                                        {
                                            break;
                                        }
                                    case 6:
                                        {
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                }
            }
        }

    }
}
