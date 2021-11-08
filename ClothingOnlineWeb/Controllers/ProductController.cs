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
            var products = context.Products.Where(c => c.Categoryid == product.Categoryid).ToList();
            return View(product);
        }
    }
}
