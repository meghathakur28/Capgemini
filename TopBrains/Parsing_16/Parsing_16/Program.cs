using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] tokens = { "21", "88", "90" };
            int sum = 0;
            foreach (string token in tokens)
            {
                int t = Int32.Parse(token);
                sum += t;
            }
            Console.WriteLine(sum);
        }

    }
}
