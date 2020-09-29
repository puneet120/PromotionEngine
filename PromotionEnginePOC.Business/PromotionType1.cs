using PromotionEnginePOC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEnginePOC.Rules;

namespace PromotionEnginePOC.Business
{
    public class PromotionType1: IPromotionType
    {
        public double CalculateTotalPrice(IList<SKU> sKUs)
        {
            double totalprice = RuleCalculation.PromotionType1Rule(sKUs);
            return totalprice;
        }
    }
}
