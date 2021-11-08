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
        [HttpGet]
        public IActionResult addToCart(int productId)
        {
            if(HttpContext.Session.GetString("cart") == null)
            {
                List<Cart> cart = new List<Cart>();
                var product = context.Products.Find(productId);
                var images = context.Images.Where(i => i.Productid == product.Productid).ToList();
                product.Images = images;
                cart.Add(new Cart
                {
                    productId = product.Productid,
                    productName = product.Productname,
                    productImage = product.Images.First().Imagelink,
                    quantity = 1,
                    price = float.Parse(product.Price)
                });
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            }
            else
            {
                List<Cart> cart = JsonConvert.DeserializeObject<List<Cart>>(HttpContext.Session.GetString("cart"));
                var product = context.Products.Find(productId);
                var images = context.Images.Where(i => i.Productid == product.Productid).ToList();
                product.Images = images;
                cart.Add(new Cart
                {
                    productId = product.Productid,
                    productName = product.Productname,
                    productImage = product.Images.First().Imagelink,
                    quantity = 1,
                    price = float.Parse(product.Price)
                });
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            }
            
            return Redirect("listproduct");
        }
    }
}
