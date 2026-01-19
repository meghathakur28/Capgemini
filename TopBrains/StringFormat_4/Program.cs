using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace StringFormat_4
{
    public class Program
    {

        public static List<Student> students = new List<Student>();

        public static void Add(string data)
        {
            Student student = new Student();
            string[] a = data.Split(':');
            student.Name = a[0];
            student.Score = Convert.ToInt32(a[1]);
            students.Add(student);
        }

        public static string MinScore(int minScore)
        {
            var minscore = students.Where(x => x.Score > minScore).OrderBy(x => x.Score).ThenBy(x => x.Name).ToList();

            return JsonSerializer.Serialize(minscore);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string in the format (Name:Score) ");
            string data = Console.ReadLine();

            Console.WriteLine("Enter the Minimum Score: ");
            int minScore = Int32.Parse(Console.ReadLine());

            Add(data);
            string minscore = MinScore(minScore);
            System.Console.WriteLine(minscore);


        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}

