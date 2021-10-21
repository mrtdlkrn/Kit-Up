using Kit_Up.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kit_Up.Controllers
{
    public class CartController : Controller
    {
        DataContext db = new DataContext();
        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }
        public ActionResult AddToCart(int UrunId)
        {
            var product = db.Urunler.FirstOrDefault(i => i.UrunId == UrunId);

            if (product != null)
            {
                GetCart().AddProduct(product, 1);
            }
            return RedirectToAction("Index");
        }
        public ActionResult RemoveFromCart(int UrunId)
        {
            var product = db.Urunler.FirstOrDefault(i => i.UrunId == UrunId);

            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }
        public Cart GetCart()
        {
            var cart = (Cart)Session["Cart"];

            if ( cart == null )
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }

    }
}