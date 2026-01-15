using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadbandPlans_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var plans = new List<IBroadbandPlan>
            {
                new Black(true,50),
                new Black(false,10),
                new Gold(true,30),
                new Black(true,20),
                new Gold(false,20)
            };

            var subscriptionPlans = new SubscribePlan(plans);
            var result = subscriptionPlans.GetSubscriptionPlan();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Item1},{item.Item2}");
            }

        }
    }
    interface IBroadbandPlan
    {
        int GetBroadbandPlanAmount();
    }
    class Black : IBroadbandPlan
    {
        private readonly bool _isSubscriptionValid;

        private readonly int _discountpercentage;

        private const int PlanAmount = 3000;

        public Black(bool isSubscriptionValid, int discountpercentage)
        {
            this._isSubscriptionValid = isSubscriptionValid;
            if (discountpercentage < 0 || discountpercentage > 50)
            {
                throw new ArgumentOutOfRangeException();
            }
            this._discountpercentage = discountpercentage;
        }

        public int GetBroadbandPlanAmount()
        {
            if(_isSubscriptionValid)
            {
                return PlanAmount - (_discountpercentage * PlanAmount / 100);
            }
            return PlanAmount;
        }

    }

    class Gold:IBroadbandPlan
    {
        private readonly bool _isSubscriptionValid;

        private readonly int _discountpercentage;

        private const int PlanAmount = 1500;

        public Gold(bool isSubscriptionValid, int discountpercentage)
        {
            this._isSubscriptionValid = isSubscriptionValid;
            if (discountpercentage < 0 || discountpercentage > 30)
            {
                throw new ArgumentOutOfRangeException();
            }
            this._discountpercentage = discountpercentage;
        }
        public int GetBroadbandPlanAmount()
        {
            if (_isSubscriptionValid)
            {
                return PlanAmount - (_discountpercentage * PlanAmount / 100);
            }
            return PlanAmount;
        }

    }

    class SubscribePlan
    {
        private readonly IList<IBroadbandPlan> _broadbandPlans;

        public SubscribePlan(IList<IBroadbandPlan> broadbandPlans)
        {
            _broadbandPlans = broadbandPlans;
        }

        public IList<Tuple<string, int>> GetSubscriptionPlan()
        {
            IList<Tuple<string, int>> plans = new List<Tuple<string, int>>();
            if (_broadbandPlans == null)
            {
                throw new ArgumentException();
            }
            foreach (var plan in _broadbandPlans)
            {
                plans.Add(new Tuple<string, int>(plan.GetType().Name, plan.GetBroadbandPlanAmount()));
            }
            return plans;
        }
    }
}
