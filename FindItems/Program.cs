using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindItems
{
    public class Program
    {
        public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>();
        public SortedDictionary<string,long> FindItemDetails(long soldCount)
        {

            var details = itemDetails.Where(x=>x.Value == soldCount);
            return (SortedDictionary<string, long>)details;
        }
        public List<String> FindMinandMaxSoldItems()
        {
            var max = itemDetails.Select(x => x.Value).Max();
            var min = itemDetails.Select(y => y.Value).Min();
            var minmax = from data in itemDetails
                              where data.Value == max || data.Value == min
                              orderby data.Value
                              select data.Key;
            return minmax.ToList();
        }
        public Dictionary<string,long> SortByCount()
        {
            var sort = from data in itemDetails
                       orderby data.Value
                       select data;
            return (Dictionary<string, long>)sort;
        }
        public static void Main(string[] args)
        {
            Program pObj = new Program();
            Console.WriteLine("Enter the sold amount");
            long soldCount = long.Parse(Console.ReadLine());

            SortedDictionary<string, long> items = pObj.FindItemDetails(soldCount);
            Console.WriteLine("Items with the sold amount: " + soldCount);

            if (items.Count == 0)
            {
                Console.WriteLine("Invalid sold count");

            }
            else
            {
                foreach (var i in items)
                {
                    Console.WriteLine(i.Key + " : " + i.Value);
                }
            }

            Console.WriteLine("Min  and Max sold Items ");
            List<string> minmaxlist = pObj.FindMinandMaxSoldItems();
            foreach (var i in minmaxlist)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Sort By Count");
            Dictionary<string, long> itemsbyCount = pObj.SortByCount();

            foreach (var i in itemsbyCount)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
        }
    }
}
