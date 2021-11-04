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
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                return RedirectToAction("listproduct", "product");
            }
            else
            {
                return RedirectToAction("Login");
            }
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
            var accounts = context.Accounts.SingleOrDefault(x => x.Username == account.Username && x.Password == account.Password);

            if (accounts != null)
            {
                //tao session
                HttpContext.Session.SetString("accountSession", JsonConvert.SerializeObject(accounts));
                if (accounts.Isadmin == true)
                {
                    return RedirectToAction("ListProduct", "Product");
                }
                else
                {
                    return RedirectToAction("ListProduct", "Product");
                }
            }
            else
            {
                return View(account);
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            Account account = new Account();
            return View(account);
        }

        [HttpPost]
        public IActionResult Register(Account account)
        {
            var accounts = context.Accounts.ToList();
            //check exist
            foreach(var c in accounts)
            {
                if(ModelState.IsValid && account.Username == c.Username)
                {
                    TempData["status"] = "Username đã tồn tại!";
                    return View(account);
                }
            }
            account.Isadmin = false;
            context.Accounts.Add(account);
            context.SaveChanges();
            HttpContext.Session.SetString("accountSession", JsonConvert.SerializeObject(account));

            return RedirectToAction("ListProduct", "Product");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("accountSession");
            return RedirectToAction("Login");
        }
    }
}
