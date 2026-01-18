using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication
{
    public class Program
    {
        public User ValidatePassword(String name, String passsword, String confirmationPassword)
        {
            User user = new User();
            user.Name = name;
            if (!confirmationPassword.Equals(passsword))
            {
                throw new PasswordMismatchException("Password entered does not match");
            }
            user.Password = passsword;
            user.ConfirmationPassword = confirmationPassword;
            return user;
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("ENter the user name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("ENter the password");
            string password = Console.ReadLine();

            Console.WriteLine("Enter the password again (confirmation passwprd) ");
            string confirmationPassword = Console.ReadLine();

            try
            {
                p.ValidatePassword(userName, password, confirmationPassword);
                System.Console.WriteLine("Registered Successfully");
            }
            catch(PasswordMismatchException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public string ConfirmationPassword {  get; set; }
    }
    public class PasswordMismatchException:Exception
        {
            public PasswordMismatchException() { }
            public PasswordMismatchException(string message) : base(message) { }
        }
}
