using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromotionEnginePOC.Models
{
    public class SkuModel
    {
        public string Id { get; set; }

        public  int Quantity { get; set; }

        public int Price { get; set; }
    }
}