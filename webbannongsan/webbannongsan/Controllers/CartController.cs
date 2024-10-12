using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webbannongsan.Models;

namespace webbannongsan.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        DB_TadNongSanEntities DB = new DB_TadNongSanEntities();
        public ActionResult CartIndex()
        {
            
            var Ac = (Account)Session["Account"];
            if (Ac == null)
            {
                return RedirectToAction("Login", "Account");
            }
            List<int>cartQuantity = new List<int>();  
            var AcID = Ac.AccountID;
            var carts=DB.Carts.Where(i=>i.AccountID == AcID).ToList();
            List<Product> products=new List<Product>();
            float sumPrice = 0;
            foreach(var cart in carts)
            {
                Product product = DB.Products.Where(i=>i.ProductID== cart.ProductID).FirstOrDefault();
                products.Add(product);
                cartQuantity.Add(cart.Quantity);
                sumPrice +=(int) product.Price* cart.Quantity;
            }
            ViewBag.sumPrice=sumPrice;
            ViewBag.CartQuantity = cartQuantity;
            return View(products);
        }
        [HttpPost]
        public ActionResult CartIndex(int ProductID)
        {
            Cart newCart= new Cart();
            
            var Ac = (Account)Session["Account"];
            if (Ac == null)
            {
                return RedirectToAction("Login", "Account");
            }
            List<int> cartQuantity = new List<int>();
            var AcID = Ac.AccountID;
            var carts = DB.Carts.Where(i => i.AccountID == AcID).ToList();
            List<Product> products = new List<Product>();
            float sumPrice = 0;
            foreach (var cart in carts)
            {
                Product product = DB.Products.Where(i => i.ProductID == cart.ProductID).FirstOrDefault();
                products.Add(product);
                cartQuantity.Add(cart.Quantity);
                sumPrice += (int)product.Price * cart.Quantity;
            }
            ViewBag.sumPrice = sumPrice;
            ViewBag.CartQuantity = cartQuantity;

            var cartTemp = DB.Carts.FirstOrDefault(i=>i.ProductID==ProductID && i.AccountID==Ac.AccountID);
            if (cartTemp==null)
            {
                newCart.ProductID = ProductID;
                newCart.AccountID = AcID;
                newCart.Quantity = 1;
                DB.Carts.Add(newCart);
                DB.SaveChanges();
            }

            return RedirectToAction("CartIndex");
        }
    }
}