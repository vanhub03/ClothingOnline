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
    public class AdminController : Controller
    {
        ProjectPRN211Context context = new ProjectPRN211Context();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                var account = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
                if(account.Isadmin!= true)
                {
                    return RedirectToAction("Index","Error");
                }
                else
                {
                    return View();
                }

                
            }
            else
            {
                return RedirectToAction("Index","Error");
            }
        
        }
       
        public IActionResult Accounts()
        {
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                var account = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
                if (account.Isadmin != true)
                {
                    return RedirectToAction("Index", "Error");
                }
                else
                {
                    return View("Account", context.Accounts.Where(c => c.Enable == true).ToList());
                }


            }
            else
            {
               return RedirectToAction("Index", "Error");
            }
           
        }
        public IActionResult Product()
        {
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                var account = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
                if (account.Isadmin != true)
                {
                    return RedirectToAction("Index", "Error");
                }
                else
                {
                    var products = context.Products.ToList();
                    foreach (var p in products)
                    {
                        var Category = context.Categories.Where(i => i.Categoryid == p.Categoryid).FirstOrDefault();

                        p.Category = Category;

                    }
                    return View(products);
                }


            }
            else
            {
                return RedirectToAction("Index", "Error");
            }
          
          
        }
        [HttpGet]
        public IActionResult AddAccount()
        {
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                var account = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
                if (account.Isadmin != true)
                {
                    return RedirectToAction("Index", "Error");
                }
                else
                {
                    return View();
                }


            }
            else
            {
                return RedirectToAction("Index", "Error");
            }
         
        }
        [HttpPost]
        public IActionResult AddAccount(Account account1)
        {
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                var account = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
                if (account.Isadmin != true)
                {
                    return RedirectToAction("Index", "Error");
                }
                else
                {
                    var accounts = context.Accounts.ToList();
                    //check exist
                    foreach (var c in accounts)
                    {
                        if (ModelState.IsValid && account1.Username == c.Username)
                        {
                            TempData["status"] = "Username đã tồn tại!";
                            return View(account1);
                        }
                    }
                    account1.Isadmin = false;
                    account1.Enable = true;
                    context.Accounts.Add(account1);
                    context.SaveChanges();

                    return RedirectToAction("Accounts", "Admin");
                }


            }
            else
            {
                return RedirectToAction("Index", "Error");
            }
            
        }


        [HttpGet]
        [Route("/Admin/EditAccount/{id}")]
        public IActionResult EditAccount(int id)
        {
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                var account = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
                if (account.Isadmin != true)
                {
                    return RedirectToAction("Index", "Error");
                }
                else
                {
                    var accounnt1 = context.Accounts.Where(i => i.Userid == id).FirstOrDefault();

                    return View(accounnt1);
                }


            }
            else
            {
                return RedirectToAction("Index", "Error");
            }
          
        }
        [HttpPost]
        public IActionResult ClickEditAccount(Account account1)
        {
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                var account = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
                if (account.Isadmin != true)
                {
                    return RedirectToAction("Index", "Error");
                }
                else
                {
                    var accountupdate = context.Accounts.Where(i => i.Userid == account.Userid).FirstOrDefault();
                    accountupdate.Address = account1.Address;
                    accountupdate.Phone = account1.Phone;
                    accountupdate.Email = account1.Email;
                    accountupdate.Enable = true;
                    context.SaveChanges();
                    return RedirectToAction("Accounts", "Admin");
                }


            }
            else
            {
                return RedirectToAction("Index", "Error");
            }
            
        }


        [HttpGet]
        [Route("/Admin/DeleteAccount/{id}")]
        public IActionResult DeleteAccount(int id)
        {
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                var account = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
                if (account.Isadmin != true)
                {
                    return RedirectToAction("Index", "Error");
                }
                else
                {
                    var accounnt1 = context.Accounts.Where(i => i.Userid == id).FirstOrDefault();
                    accounnt1.Enable = false;
                    context.SaveChanges();

                    return RedirectToAction("Accounts", "Admin");
                }


            }
            else
            {
                return RedirectToAction("Index", "Error");
            }
           
            
        }


        [HttpGet]
        [Route("/Admin/UpdateAdmin/{id}")]
        public IActionResult UpdateAdmin(int id)
        {
            if (HttpContext.Session.GetString("accountSession") != null)
            {
                var account = JsonConvert.DeserializeObject<Account>(HttpContext.Session.GetString("accountSession"));
                if (account.Isadmin != true)
                {
                    return RedirectToAction("Index", "Error");
                }
                else
                {
                    var accounnt1 = context.Accounts.Where(i => i.Userid == id).FirstOrDefault();
                    if (accounnt1.Isadmin == false)
                    { accounnt1.Isadmin = true; }
                    else
                    {
                        accounnt1.Isadmin = false;
                    }

                    context.SaveChanges();

                    return RedirectToAction("Accounts", "Admin");
                }


            }
            else
            {
                return RedirectToAction("Index", "Error");
            }
          

        }
    }
}
