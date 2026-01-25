using System;
using System.Data;
namespace StreamBuzzCollectionBasedProblem
{
    public class Program
    {
        public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();


        public void RegisterCreator(CreatorStats record)
        {
            EngagementBoard.Add(record); 
        }

        public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
        {
            Dictionary<string, int> countWeeklyLikes = new Dictionary<string, int>();

            foreach (var record in records)
            {
                int count = 0;
                for(int i=0;i<4;i++)
                {
                    if(record.WeeklyLikes[i] >= likeThreshold)
                    {
                        count++;
                    }
                }
                if (count > 0)
                {

                    countWeeklyLikes[record.CreatorName] = count;
                }
            }
            return countWeeklyLikes;
        }

        public double CalculateAverageLikes()
        {
            double average = 0;
            double sum = 0;
            foreach (var record in EngagementBoard)
            {
                for(int i=0;i<4;i++)
                {
                    sum += record.WeeklyLikes[i];
                }
            }
            average =  sum/(EngagementBoard.Count()*4);
            return average;
        }

        public static void Menu()
        {
            Console.WriteLine("\n1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            int choice = 0;
            while (choice != 4)
            {
                Menu();
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("\nEnter Creator Name: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Enter weekly likes(Week 1 to 4: ");
                            double[] weeklylikes = new double[4];
                            for (int i = 0; i < 4; i++)
                            {
                                weeklylikes[i] = double.Parse(Console.ReadLine());
                            }
                            CreatorStats creator = new CreatorStats();
                            creator.CreatorName = name;
                            creator.WeeklyLikes = weeklylikes;
                            p.RegisterCreator(creator);
                            Console.WriteLine("Creator registered successfully");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nEnter like threshold: ");
                            double threashold = double.Parse(Console.ReadLine());

                            Dictionary<string, int> topPost = p.GetTopPostCounts(EngagementBoard, threashold);

                            if (topPost.Count()==0)
                            {
                                Console.WriteLine("No top-performing posts this week");
                            }
                            else
                            {
                                foreach (var i in topPost)
                                {
                                    Console.WriteLine($"{i.Key} - {i.Value}");
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nOverall average weekly likes: " + p.CalculateAverageLikes());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nLogging off - Keep Creating with StreamBuzz!");
                            break;
                        }
                }
            }
        }
    }
}
