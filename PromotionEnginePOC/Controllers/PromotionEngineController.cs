using PromotionEnginePOC.Business;
using PromotionEnginePOC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PromotionEnginePOC.Controllers
{
    public class PromotionEngineController : Controller
    {
        private readonly IPromotionType _promotionType;

        public PromotionEngineController(IPromotionType promotionType)
        {
           this._promotionType = promotionType;
        }
      
        // GET: PromotionEngine
        public ActionResult Index()
        {          
            return View();
        }

        [HttpPost]
        public ActionResult Index(string content)
        {
            var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SKU>>(content);
            double price= _promotionType.CalculateTotalPrice(list);
            ViewBag.Price = price;
            return View();
        }

        // GET: PromotionEngine/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PromotionEngine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PromotionEngine/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PromotionEngine/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PromotionEngine/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PromotionEngine/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PromotionEngine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
