using ClothingOnlineWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingOnlineWeb.Controllers
{
    public class AdminController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Accounts()
        {
            ProjectPRN211Context context = new ProjectPRN211Context();
            return View("tables",context.Accounts.ToList());
        }
        public IActionResult Product()
        {
            ProjectPRN211Context context = new ProjectPRN211Context();
            return View(context.Products.ToList());
        }
    }
}
