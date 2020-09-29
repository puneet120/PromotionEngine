using PromotionEnginePOC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEnginePOC.Business
{
   public interface IPromotionType
    {
        /// <summary>
        /// Calculate Total Price based on Promotion Type
        /// </summary>
        /// <param name="sKUs"></param>
        /// <returns></returns>
        double CalculateTotalPrice(IList<SKU> sKUs);
    }
}
