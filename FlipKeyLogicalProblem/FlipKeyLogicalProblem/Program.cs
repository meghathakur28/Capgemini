using System;
using System.Linq;

namespace FlipKeyLogicalProblem
{
    public class Program
    {
        public string CleanseAndInvert(string input)
        {
            if (input == null || input.Length < 6)
            {
                return null;
            }
            bool digit = input.Any(char.IsDigit);
            if (digit) { return null; }

            bool space = input.Any(char.IsWhiteSpace);
            if(space) { return null; }

            input = input.ToLower();
            string ASCII = "";

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] % 2 != 0)
                {
                    ASCII += input[i];
                }
            }

            string rev = "";
            for(int i=ASCII.Length-1;i>=0 ;i--)
            {
                rev += ASCII[i];
            }
            string ans = "";

            for (int i = 0; i < rev.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ans += char.ToUpper(rev[i]);
                }
                else
                {
                    ans += rev[i];
                }
            }

            return ans;



        }


            


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();
            Program p = new Program();
            string Key = p.CleanseAndInvert(input);
            if(Key  == null)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine("The generated key is: " + Key);
            }
        }
    }
}
