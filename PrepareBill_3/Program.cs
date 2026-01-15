using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareBill_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commodities = new List<Commodity>()
            {
                new Commodity(CommodityCategory.Furniture,"Bed",2,50000),
                new Commodity(CommodityCategory.Grocery,"Flour",5,80),
                new Commodity(CommodityCategory.Service,"Insurance",8,8500)
            };
            var prepareBill = new PrepareBill();
            prepareBill.SetTaxRates(CommodityCategory.Furniture, 18);
            prepareBill.SetTaxRates(CommodityCategory.Grocery, 5);
            prepareBill.SetTaxRates(CommodityCategory.Service, 12);

            var billAmount = prepareBill.CalculateBillAmount(commodities);
            Console.WriteLine($"{billAmount}");
        }
    }
    public enum CommodityCategory
    {
        Furniture,
        Grocery,
        Service
    }
    class Commodity
    {
        public CommodityCategory category {  get; set; }

        public string CommodityName {  get; set; }

        public int CommodityQuantity {  get; set; }

        public double CommodityPrice { get; set; }
        public Commodity(CommodityCategory category, string commodityName,int commodityQuantity,double commodityPrice)
        {
            this.category = category;
            this.CommodityName = commodityName;
            this.CommodityPrice = commodityPrice;
            this.CommodityQuantity = commodityQuantity;
        }


    }
    class PrepareBill
    {
        private readonly IDictionary<CommodityCategory, double> _taxRates;

        public PrepareBill()
        {
            _taxRates = new Dictionary<CommodityCategory, double>();
        }

        public void SetTaxRates(CommodityCategory category,double taxRate)
        {
            if(!_taxRates.Keys.Contains(category)) 
                {
                    _taxRates.Add(category, taxRate);
                }
        }
        public double CalculateBillAmount(IList<Commodity> items)
        {
            double total = 0;
            foreach (var item in items)
            {
               if(_taxRates.Keys.Contains(item.category))
                {
                    total += (item.CommodityQuantity *( item.CommodityPrice + (_taxRates[item.category]*item.CommodityPrice)/100));
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            return total;
        }

    }
}
