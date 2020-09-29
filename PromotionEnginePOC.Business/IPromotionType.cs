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
        double CalculateTotalPrice(IList<SKU> sKUs);
    }
}
