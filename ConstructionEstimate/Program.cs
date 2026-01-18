using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionEstimate
{
    public class Program
    {

        public EstimateDetails ValidateConstructionEstimate(float ConstructionArea , float siteArea)
        {
            EstimateDetails details = new EstimateDetails();
            if(ConstructionArea <= siteArea)
            {
                details.ConstructionArea = siteArea; 
                details.SiteArea = siteArea;
                return details;
            }
            throw new ConstructionEstimateException("Sorry your Construction Estimate is not approved");
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the construction area: ");
            float constructionArea = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the SiteArea: ");
            float siteArea = float.Parse(Console.ReadLine());

            try
            {
                p.ValidateConstructionEstimate(constructionArea, siteArea);
                Console.WriteLine("Approved");
            }
            catch(ConstructionEstimateException e)
            {
                Console.WriteLine(e.Message); 
            }


        }
    }
    public class EstimateDetails
    {
        public float ConstructionArea {  get; set; }
        public float SiteArea { get; set; }
    }
    public class ConstructionEstimateException:Exception
    {
        public ConstructionEstimateException() { }

        public ConstructionEstimateException(string message) : base(message) { }



    }
}
