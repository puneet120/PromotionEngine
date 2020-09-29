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
        /// <summary>
        /// Based on Promotion Type 1
        /// Multiple Promotion types can be added in future with the common interface
        /// </summary>
        /// <param name="sKUs"></param>
        /// <returns></returns>
        public double CalculateTotalPrice(IList<SKU> sKUs)
        {
            double totalprice = RuleCalculation.PromotionType1Rule(sKUs);
            return totalprice;
        }
    }
}
