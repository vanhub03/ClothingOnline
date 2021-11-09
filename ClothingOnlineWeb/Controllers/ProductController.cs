using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using ClothingOnlineWeb.Models;

namespace ClothingOnlineWeb.Controllers
{
    public class ProductController : Controller
    {
        public const string CARTKEY = "cart";
        ProjectPRN211Context context = new ProjectPRN211Context();
        public IActionResult ListProduct()
        {
            if(HttpContext.Session.GetString("accountSession") != null)
            {
                TempData["account"] = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
            }
            var products = context.Products.Where(p => p.Enable == true).ToList();
            foreach(var p in products)
            {
                var images = context.Images.Where(i => i.Productid == p.Productid).ToList();
                foreach(var i in images)
                {
                    p.Images.Add(i);
                }
            }
            return View(products);
        }
        public IActionResult getProductDetail(int id)
        {
            var product = context.Products.Find(id);
            var images = context.Images.Where(i => i.Productid == id).ToList();
            product.Images = images;
            var products = context.Products.Where(c => c.Productid != product.Productid && c.Categoryid == product.Categoryid).ToList();
            foreach (var p in products)
            {
                var imageRelated = context.Images.FirstOrDefault(i => i.Productid == p.Productid);
                p.Images.Add(imageRelated);
            }
            ViewBag.productRelate = products;
            return View(product);
        }
        //lay cart tu session
        List<Cart> GetCarts()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if(jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<Cart>>(jsoncart);
            }
            return new List<Cart>();
        }
        //xoa cart khoi session
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }
        //luu danh sach cart vao session
        void saveCartSession(List<Cart> listCart)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(listCart);
            session.SetString(CARTKEY, jsoncart);
        }
        public IActionResult addToCart(int productId)
        {
            var product = context.Products.Where(p => p.Productid == productId).FirstOrDefault();
            if(product == null)
            {
                return NotFound("Gio hang trong");
            }
            var cart = GetCarts();
            var cartitem = cart.Find(p => p.product.Productid == productId);
            if(cartitem != null)
            {
                cartitem.quantity++;
            }
            else
            {
                cart.Add(new Cart() { quantity = 1, product = product });
            }

            saveCartSession(cart);
            return RedirectToAction("listproduct");
        }
    }
}
