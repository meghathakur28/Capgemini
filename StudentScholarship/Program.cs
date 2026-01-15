using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScholarship
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {

            new Student() { RollNo= 1,Name = "Raj", Marks = 75, SportsGrade = 'A'},
             new Student() { RollNo =2, Name = "Rahul", Marks = 82, SportsGrade = 'A' },
             new Student() { RollNo =3, Name = "Kiran", Marks = 89, SportsGrade = 'B' },
            new Student() { RollNo = 4, Name = "Sunil", Marks = 86, SportsGrade = 'A' },};

            IsEligibleforScholarship studscholar = ScholarshipEligibility;

            Console.WriteLine(Student.GetEligibleStudents(students, studscholar));
        }

        public static bool ScholarshipEligibility(Student std)
        {
            bool flag = false;
            if(std.Marks>80&& std.SportsGrade == 'A')
            {
                flag = true;
            }
            return flag;
        }
    }
    public delegate bool IsEligibleforScholarship(Student std);
    public class Student
    {
         public int RollNo {  get; set; }
         public string Name { get; set; }
         
         public int Marks { get; set; }

         public char SportsGrade {  get; set; }

         public static string GetEligibleStudents(List<Student> studentsList, IsEligibleforScholarship isEligible)
         {
            string student = String.Empty;
            foreach (var list in studentsList)
            {
                if(isEligible(list))
                {
                    student += list.Name;
                    student += ", ";
                }
            }
            return student;
         }

    }
}
