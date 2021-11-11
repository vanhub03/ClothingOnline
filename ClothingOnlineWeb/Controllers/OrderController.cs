using ClothingOnlineWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingOnlineWeb.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddToOrder()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString("cart");
            List<Cart> carts = new List<Cart>();
            if (jsoncart != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(jsoncart);
            }
            return View(carts);
        }
    }
}
