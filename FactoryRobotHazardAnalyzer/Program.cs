using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryRobotHazardAnalyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            double armPrecision;
            int workerDensity;
            string machineryState;
            Console.WriteLine("Enter the arm precision: ");
            armPrecision = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the workerDensity: ");
            workerDensity = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the machineryState: ");
            machineryState = Console.ReadLine();

            try
            {
                if(armPrecision<0.0||armPrecision>1.0)
                {
                    throw new RobotSafetyException("Arm precision must be 0.0-1.0");
                }
                if(workerDensity<1|| workerDensity>20)
                {
                    throw new RobotSafetyException("Worker density must be 1-20");
                }
                if(machineryState != "Worn"&& machineryState != "Faulty" && machineryState != "Critical")
                {
                    throw new RobotSafetyException("Unsupported machinery state.");
                }
                System.Console.WriteLine("Robot Hazard Risk Score: "+CalculateHazardRisk(armPrecision, workerDensity, machineryState));


            }
            catch(RobotSafetyException e)
            {
                System.Console.WriteLine("Error: " +e.Message);
            }
        }

        public static double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
            double machineRiskFactor = 0;
            if (machineryState == "Worn") machineRiskFactor = 1.3;
            else if (machineryState == "Faulty") machineRiskFactor = 2.0;
            else if (machineryState == "Critical") machineRiskFactor = 3.0;
            return (((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor));
        }
    }

    public class RobotSafetyException : Exception {
        public RobotSafetyException() { }

        public RobotSafetyException(string message) : base(message) { }
    }
}
