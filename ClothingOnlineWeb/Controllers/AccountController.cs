using ClothingOnlineWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ClothingOnlineWeb.Controllers
{
    public class AccountController : Controller
    {
        ProjectPRN211Context context = new ProjectPRN211Context();
        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            Account account = new Account();
            return View(account);
        }
        [HttpPost]
        public IActionResult Login(Account account)
        {
            //so sanh Account voi du lieu tu database duoc submit
            var accounts = context.Accounts;
            foreach (var c in accounts)
            {
                if (ModelState.IsValid && account.Username == c.Username && account.Password == c.Password)
                {
                    //tao session
                    HttpContext.Session.SetString("accountSession", JsonConvert.SerializeObject(account));
                    if (c.Isadmin == true)
                    {
                        return null;
                    }
                    else
                    {
                        return RedirectToAction("ListProduct", "Product");
                    }
                }
            }
            return View(account);
        }
    }
}
