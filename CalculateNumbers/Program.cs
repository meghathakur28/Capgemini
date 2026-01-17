using System;
using System.Security.Cryptography.X509Certificates;
namespace CalculateNumbers
{
    public class Program
    {
        public static List<int> NumberList = new List<int>();

        public void AddNumbers(int number)
        {
            NumberList.Add(number);
        }
        public double GetGPAScored()
        {
            double total = 0;
            if (NumberList.Count == 0)
            {
                return -1;
            }
            foreach (var i in NumberList)
            {
                total += i*3;
            }
            double count  = NumberList.Count*3;
            return total / count;
        }
        public char GetGradeScored(double gpa)
        {
            if (gpa >= 5 && gpa < 6) return 'E';
            else if (gpa >= 6 && gpa < 7) return 'D';
            else if (gpa >= 7 && gpa < 8) return 'C';
            else if (gpa >= 8 && gpa < 9) return 'B';
            else if (gpa >= 9 && gpa < 10) return 'A';
            else if (gpa == 10) return 'S';
            else return 'Z';
        }

        public static void Main()
        {
            Program pObj = new Program();
            System.Console.WriteLine("Enter the number: ");
            int num = Int32.Parse(Console.ReadLine());
            pObj.AddNumbers(num);

            Console.WriteLine("Your GPA");
            double gpa = pObj.GetGPAScored();
            if (gpa < 0)
            {
                Console.WriteLine("No Numbers Available");
            }
            else
            {
                Console.WriteLine(gpa);
            }
            if (pObj.GetGradeScored(gpa) == 'Z')
            {
                Console.WriteLine("Invalid GPA");
            }
            else
            {
                Console.WriteLine("Your Grade is: " + pObj.GetGradeScored(gpa));
            }


        }
    }

}
