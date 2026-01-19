using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSorting_20
{
    public class Student
    {
        public string Name {get; set; }
        public int Age { get; set; }

        public double Marks {  get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            student.Add(new Student { Name = "Megha", Age = 21, Marks = 81.4 });
            student.Add(new Student { Name = "Abhinav", Age = 20, Marks = 90.23});
            student.Add(new Student { Name = "Parth", Age = 22, Marks = 81.10 });
            student.Add(new Student { Name = "Nisha Agarwal", Age = 23, Marks = 81.98 });
            student.Add(new Student { Name = "Anshika", Age = 22, Marks = 68.56 });

            var SortedList = student.OrderByDescending(x => x.Marks).ThenBy(x => x.Age).ToList();

            Console.WriteLine("The Sorted List: ");
            foreach(var i in SortedList)
            {
                Console.WriteLine($"Name: {i.Name}, Marks: {i.Marks}, Age: {i.Age} ");
            }
        }


    }
}
