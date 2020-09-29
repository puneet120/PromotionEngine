using PromotionEnginePOC.Entity;
using PromotionEnginePOC.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEnginePOC.Business
{
    public class PromotionType2 : IPromotionType
    {
        public double CalculateTotalPrice(IList<SKU> sKUs)
        {
            double totalprice = RuleCalculation.PromotionType2Rule(sKUs);
            return totalprice;
        }

    }
}
