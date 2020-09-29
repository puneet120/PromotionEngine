using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEnginePOC.Business;
using PromotionEnginePOC.Controllers;
using PromotionEnginePOC.Entity;

namespace PromotionEnginePOC.Tests.Controllers
{
    [TestClass]
    public class PromotionEngineTest
    {
        [TestMethod]
        public void CalculateTotalPriceifSkuListHasCount0()
        {
            // Arrange
            PromotionType1 promotionType = new PromotionType1();

            // Act
            double result = promotionType.CalculateTotalPrice(new List<SKU>());

            // Assert
            Assert.AreEqual(0,result);
        }
        [TestMethod]
        public void CalculateTotalPriceifQuantityIsNegative()
        {
            IList<SKU> skulist = new List<SKU>();
            skulist.Add(new SKU
            {
                Quantity = -1
            });
            // Arrange
            PromotionType1 promotionType = new PromotionType1();

            // Act
            double result = promotionType.CalculateTotalPrice(skulist);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculateTotalPriceifListIsNull()
        {
            Exception expectedex = null;
            // Arrange
            PromotionType1 promotionType = new PromotionType1();

            // Act
            try
            {
                var result = promotionType.CalculateTotalPrice(null);
            }
            catch(Exception ex)
            {
                expectedex = ex;
            }

            // Assert
            
           Assert.IsNotNull(expectedex);
        }
    }
}
