using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserVerification
{
    public class Program
    {
        public User ValidatePhoneNumber(string name, string phoneNumber)
        {
            User user = new User();
            if(phoneNumber.Length != 10)
            {
                throw new InvalidPhoneNumberException("Invalid phone number");
            }

            user.Name = name;
            user.PhoneNumber = phoneNumber;
            return user;

        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Phone Number: ");
            string phoneNumber = Console.ReadLine();

            try
            {
                p.ValidatePhoneNumber(name, phoneNumber);
                Console.WriteLine("Phone Number is valid");
            }
            catch(InvalidPhoneNumberException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public class User
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException() { }
        public InvalidPhoneNumberException(string message) : base(message) { }
    }
}
