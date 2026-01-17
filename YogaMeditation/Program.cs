using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaMeditation
{
    public class Program
    {
        public static ArrayList memberList = new ArrayList();

        public void AddYogaMember(int memberId, int age, double weight, double height, string goal)
        {
            MeditationCentre member  = new MeditationCentre();
            member.MemberId = memberId;
            member.Age = age;
            member.Weight = weight;
            member.Height = height;
            member.Goal = goal;
            member.BMI = 0;
            memberList.Add(member);
        }
        public double CalculateBMI(int memberId)
        {
            double bBMI = 0;
           
                MeditationCentre member = null;
            foreach (var i in memberList)
            {
                MeditationCentre im = (MeditationCentre)i;
                if (im.MemberId == memberId)
                {
                    member = im;
                }
            }
            if (member == null)
            {
                return 0;
            }
            bBMI = member.Weight / member.Height;
            return Math.Round(bBMI,2);

        }

        public int CalculateYogaFee(int memberId)
        {
            MeditationCentre member = null;
            foreach (var i in memberList)
            {
                MeditationCentre im = (MeditationCentre)i;
                if (im.MemberId == memberId)
                {
                    member = im;
                }
            }
            if (member.Goal == "Weight Gain") return 2500;
            else
            {
                if (member.BMI >= 25 && member.BMI < 30) return 2000;
                else if (member.BMI >= 30 && member.BMI < 35) return 2500;
                else if (member.BMI >= 35) return 3000;
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the member id: ");
            int memberID = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the age: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the weight: ");
            double weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height: ");
            double height = Double.Parse(Console.ReadLine());

            Console.WriteLine("ENter the Goal: ");
            string goal = Console.ReadLine();

            p.AddYogaMember(memberID, age, weight, height,goal);

            Console.WriteLine("Enter the id for which u want to calculate BMI");
            int id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("BMI: " + p.CalculateBMI(id));

            Console.WriteLine("Enter the id for which u want to calculate fees");
            int ids  = int.Parse(Console.ReadLine());
            Console.WriteLine("Yoga Fees: "+p.CalculateYogaFee(ids));
        }
    }
    public class MeditationCentre
    {
        public int MemberId {  get; set; }
        public int Age {  get; set; }
        public double Weight {  get; set; }
        public double Height {  get; set; }
        public string Goal {  get; set; }

        public double BMI {  get; set; }

    }
}
