using System;
namespace AuthenticationState
{
    class Program
    {
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Logout");
            Console.WriteLine("4. Exit");
            Console.ResetColor();
        }
        public static void Main(string[] args)
        {
            ApplicationAuthState appAuthState = new ApplicationAuthState(new List<string> { "USA", "Canada", "UK" });
            int choice = 0;
            while (choice != 4)
            {
                Menu();
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter the ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter username: ");
                            string regUsername = Console.ReadLine();
                            Console.Write("Enter password: ");
                            string regPassword = Console.ReadLine();
                            Console.Write("Enter location: ");
                            string regLocation = Console.ReadLine();
                            IUser newUser = new User(id, regUsername, regPassword, regLocation);
                            Console.WriteLine(appAuthState.Register(newUser));
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter the ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter username: ");
                            string regUsername = Console.ReadLine();
                            Console.Write("Enter password: ");
                            string regPassword = Console.ReadLine();
                            Console.Write("Enter location: ");
                            string regLocation = Console.ReadLine();
                            IUser newUser = new User(id, regUsername, regPassword, regLocation);
                            Console.WriteLine(appAuthState.Login(newUser));
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter the ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter username: ");
                            string regUsername = Console.ReadLine();
                            Console.Write("Enter password: ");
                            string regPassword = Console.ReadLine();
                            Console.Write("Enter location: ");
                            string regLocation = Console.ReadLine();
                            IUser newUser = new User(id, regUsername, regPassword, regLocation);
                            Console.WriteLine(appAuthState.Logout(newUser));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Exiting...");
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