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
        public IActionResult ListProduct()
        {
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                TempData["user"] = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
            }
            return View();
        }
    }
}
