using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using ClothingOnlineWeb.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClothingOnlineWeb.Controllers
{
    public class ProductController : Controller
    {
        public const string CARTKEY = "cart";
        ProjectPRN211Context context = new ProjectPRN211Context();
        public IActionResult ListProduct(int pg=1)
        {
            var products = context.Products.Where(p => p.Enable == true).ToList();
            foreach(var p in products)
            {
                var images = context.Images.Where(i => i.Productid == p.Productid).ToList();
                foreach(var i in images)
                {
                    p.Images.Add(i);
                }
            }
            const int pageSize = 10;
            if (pg < 1)
                pg = 1;

            int rescCount = products.Count();
            var pager = new Models.Page(rescCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = products.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;

            return View(data);
        }
        public IActionResult getProductDetail(int id)
        {
            var product = context.Products.Find(id);
            var images = context.Images.Where(i => i.Productid == id).ToList();
            product.Images = images;
            var products = context.Products.Where(c => c.Productid != product.Productid && c.Price > product.Price - 100000 && c.Price < product.Price + 100000).ToList();
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

        public IActionResult RemoveItemInCart(int productId)
        {
            var cart = GetCarts();
            var cartItem = cart.Find(c => c.product.Productid == productId);
            if(cartItem != null)
            {
                cart.Remove(cartItem);
            }
            saveCartSession(cart);
            return RedirectToAction("ViewCart");
        }

        public IActionResult ViewCart()
        {
            return View(GetCarts());
        }

        public IActionResult getProductByCategory(int id)
        {
            var products = context.Products.Where(p => p.Categoryid == id && p.Enable == true).ToList();
            foreach (var p in products)
            {
                var images = context.Images.Where(i => i.Productid == p.Productid).ToList();
                foreach (var i in images)
                {
                    p.Images.Add(i);
                }
            }
            return View(products);
        }

        public IActionResult getHotProduct()
        {
            var products = context.Products.Where(p => p.Enable == true).ToList();
            List<Product> sortProduct = new List<Product>();
            foreach(var item in products)
            {
                var orderDetails = context.OrderDetails.Where(p => p.Productid == item.Productid).ToList();
                var images = context.Images.Where(i => i.Productid == item.Productid).ToList();
                
                foreach(var i in images)
                {
                    item.Images.Add(i);
                }
                foreach(var order in orderDetails)
                {
                    if (item.Productid == order.Productid)
                    {
                        sortProduct.Add(item);
                    }
                }
            }
            List<Product> distinct = sortProduct.Distinct().ToList();
            return View(distinct);
        }

        public IActionResult getNewestProduct()
        {
            var products = context.Products.Where(p => p.Enable == true).ToList();
            foreach (var p in products)
            {
                var images = context.Images.Where(i => i.Productid == p.Productid).ToList();
                foreach (var i in images)
                {
                    p.Images.Add(i);
                }
            }
            products.Sort((x, y) => y.CreatedDate.CompareTo(x.CreatedDate));
            return View(products);
        }

        [HttpPost]
        public IActionResult Search(string keyWord)
        {
            var products = context.Products.Where(c => c.Productname.Contains(keyWord) || c.Category.Categoryname.Contains(keyWord)).ToList();
            foreach (var p in products)
            {
                var images = context.Images.Where(i => i.Productid == p.Productid).ToList();
                foreach (var i in images)
                {
                    p.Images.Add(i);
                }
            }
            return View(products);
        }
    }
}
