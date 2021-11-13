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
        public IActionResult WasBan()
        {
            return View();
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
                    return RedirectToAction("Accounts", "Admin");
                }else if(accounts.Enable == false)
                {
                    HttpContext.Session.Remove("accountSession");
                    return View("WasBan");
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
            if (ModelState.IsValid)
            {
                var accounts = context.Accounts.ToList();
                //check exist
                foreach (var c in accounts)
                {
                    if (ModelState.IsValid && account.Username == c.Username)
                    {
                        TempData["status"] = "Username đã tồn tại!";
                        return View(account);
                    }
                }
                account.Isadmin = false;
                account.Enable = true;
                context.Accounts.Add(account);
                context.SaveChanges();
                HttpContext.Session.SetString("accountSession", JsonConvert.SerializeObject(account));

                return RedirectToAction("ListProduct", "Product");
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("accountSession");
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult UpdateAccount(int id)
        {
            Account account = context.Accounts.Find(id);
            return View(account);
        }
        [HttpPost]
        public IActionResult UpdateAccount(Account account, string newPassword, string rePassword)
        {
            if (ModelState.IsValid)
            {
                var tempAccount = context.Accounts.Where(t => t.Userid == account.Userid && t.Password == account.Password).FirstOrDefault();
                if (tempAccount == null)
                {
                    TempData["status"] = "Mật khẩu cũ không đúng";
                    return View(account);
                }
                else if(newPassword != rePassword)
                {
                    TempData["status"] = "Xác nhận mật khẩu không chính xác";
                    return View(account);
                }
                else
                {
                    tempAccount.Password = newPassword;
                    tempAccount.Address = account.Address;
                    tempAccount.Phone = account.Phone;
                    tempAccount.Email = account.Email;
                    tempAccount.Isadmin = false;
                    tempAccount.Enable = true;
                    context.SaveChanges();
                    HttpContext.Session.SetString("accountSession", JsonConvert.SerializeObject(tempAccount));

                    return RedirectToAction("ListProduct", "Product");
                }
            }
            return View();
        }
    }
}
