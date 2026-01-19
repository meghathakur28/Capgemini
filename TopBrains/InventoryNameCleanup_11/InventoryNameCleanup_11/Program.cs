using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryNameCleanup_11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string word = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                if(i==0 || word[i] != word[i-1])
                {
                    sb.Append(word[i]);
                }
            }

            string ans = sb.ToString();

            string ansTitleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ans.Trim().ToLower());
            Console.WriteLine(ansTitleCase);

        }
    }
}
