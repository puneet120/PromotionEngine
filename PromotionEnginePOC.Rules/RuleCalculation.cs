using PromotionEnginePOC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEnginePOC.Rules
{
    public static class RuleCalculation
    {     

        public static double PromotionType1Rule(IList<SKU> sKU)
        {
            double totalprice = 0;
            try
            {
                foreach (var item in sKU)
                {
                    double price = 0;
                    switch (item.Quantity)
                    {
                        case int n when item.Quantity >= 3:
                            price = ((n - 3) * item.Price) + 130; // Will be populated from db 
                            break;
                        case int n when item.Quantity >= 2:
                            price = ((n - 2) * item.Price) + 45; // Hard Coded values will be populated from db
                            break;
                        default:
                            price = item.Price * item.Quantity;
                            break;
                    }
                    totalprice = totalprice + price;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return totalprice;
            
        }

        public static double PromotionType2Rule(IList<SKU> sKU)
        {
            double totalprice = 0;
            try
            {
                foreach (var item in sKU)
                {
                    double price = (item.Price / sKU.Count) * item.Quantity;
                    totalprice = totalprice + price;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }


            return totalprice;

        }
    }
}
