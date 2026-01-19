using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahirlAlphabetsVowels
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word ");
            string w1 = Console.ReadLine().ToLower();
             

            Console.WriteLine("Enter the second word");
            string w2 = Console.ReadLine().ToLower();

            StringBuilder consonants = new StringBuilder();
            string vowels = "aeiou";

            foreach (var i in w1)
            {
                if (!vowels.Contains(i) && w2.Contains(i))
                {
                    continue;
                }
                else
                {
                    consonants.Append(i);
                }
            }

            StringBuilder ans = new StringBuilder();
            for(int i= 0; i < consonants.Length;i++)
            {
                if (i==0 || consonants[i] != consonants[i-1] )
                {
                    ans.Append(consonants[i]);
                }
            }

            Console.WriteLine(ans);




        }
    }
}
