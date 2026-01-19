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

            string consonants =String.Empty;

            foreach (var i in w1)
            {
                if (i == 'a' || i=='e'|| i =='i' || i== 'o'|| i=='u')
                {
                    if (w2.Contains(i))
                    {
                        consonants += i;
                    }
                }
            }

            StringBuilder ans = new StringBuilder();
            for(int i= 1; i < consonants.Length;i++)
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
