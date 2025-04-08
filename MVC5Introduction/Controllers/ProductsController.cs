using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Introduction.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        //[AcceptVerbs(HttpVerbs.Get)]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]  
        public ActionResult Create(string name,string price)
        {
            //return View();
            return RedirectToAction("Details",new {productId = 0,
                name =name,price = price});
        }


        [HttpGet]
        public ActionResult Details(int? productId,string name,int? price)
        {
            ViewBag.ProductId = productId;
            ViewBag.Name = name;
            ViewBag.Price = price;
            return View();
        }
    }
}