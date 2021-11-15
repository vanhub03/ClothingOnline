using ClothingOnlineWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http.Headers;

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
        public IActionResult Order()
        {
            var orders = context.Orders.ToList();
            return View(orders);
        }
        public IActionResult SeeProductInOrder(int id)
        {
            var order = context.Orders.Find(id);

            var orderdetails = context.OrderDetails.Where(o => o.OrderId == order.Orderid).ToList();
            foreach (var orderdetail in orderdetails)
            {
                var product = context.Products.Find(orderdetail.Productid);
                orderdetail.Product = product;
                order.OrderDetails.Add(orderdetail);
            }
            return View(order);
        }
        public IActionResult ConfirmOrder(int id)
        {
            var order = context.Orders.Find(id);
            if (order.Status == 2) { 
                order.Status = 3;
                var orderdetails = context.OrderDetails.Where(o => o.OrderId == order.Orderid).ToList();
                foreach (var orderdetail in orderdetails)
                {
                    var product = context.Products.Find(orderdetail.Productid);
                    orderdetail.Product = product;
                    product.Unitinstock = product.Unitinstock - orderdetail.Quantity;
                    if (product.Unitinstock <= 0)
                    {
                        product.Enable = false;
                    }
                    context.SaveChanges();
                }

            }
            else { 
                if(order.Status == 3)
                {
                    order.Status = 1;
                    var orderdetails = context.OrderDetails.Where(o => o.OrderId == order.Orderid).ToList();
                    foreach (var orderdetail in orderdetails)
                    {
                        var product = context.Products.Find(orderdetail.Productid);
                        orderdetail.Product = product;
                        product.Unitinstock = product.Unitinstock - orderdetail.Quantity;
                        if (product.Unitinstock <= 0)
                        {
                            product.Enable = false;
                        }
                        context.SaveChanges();
                    }
                }
            }
           
            return RedirectToAction("Order", "Admin");
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
            if (ModelState.IsValid)
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
            return View();

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
        [HttpGet]
        public IActionResult AddProduct()
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

        [HttpGet]
        [Route("/Admin/UpdateProduct/{id}")]
        public IActionResult UpdateProduct(int id)
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
                    var product = context.Products.Where(i => i.Productid == id).FirstOrDefault();
                    if (product.Enable == false)
                    { product.Enable = true; }
                    else
                    {
                        product.Enable = false;
                    }

                    context.SaveChanges();

                    return RedirectToAction("Product", "Admin");
                }


            }
            else
            {
                return RedirectToAction("Index", "Error");
            }


        }
        private IHostingEnvironment _hostingEnv;
        public AdminController(IHostingEnvironment hostingEnv)
        {
            _hostingEnv = hostingEnv;
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product, List<IFormFile> ImageFile)
        {

            if (ModelState.IsValid)
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


                        product.CreatedDate = DateTime.Now;
                        product.Enable = true;
                        context.Products.Add(product);
                        context.SaveChanges();


                        foreach (var i in ImageFile) {

                            var lastproduct = context.Products.OrderByDescending(s => s.Productid).FirstOrDefault();
                            Image image = new Image();
                            image.Productid = lastproduct.Productid;
                            var filename = ContentDispositionHeaderValue.Parse(i.ContentDisposition).FileName.Trim('"');
                            var uniqueFileName = GetUniqueFileName(filename);
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", uniqueFileName);
                            using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                            {
                                await i.CopyToAsync(stream);
                            }
                            image.Imagelink = uniqueFileName;

                            context.Images.Add(image);

                            context.SaveChanges();

                        }



                        return RedirectToAction("Product", "Admin");
                    }


                }
                else
                {
                    return RedirectToAction("Index", "Error");
                }
            }
            return View();

        }
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }

        [HttpGet]
        [Route("/Admin/EditProduct/{id}")]
        public IActionResult EditProduct(int id)
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
                    var product1 = context.Products.Where(i => i.Productid == id).FirstOrDefault();
                    var images = context.Images.Where(i => i.Productid == product1.Productid).ToList();
                    foreach (var i in images)
                    {
                        product1.Images.Add(i);
                    }
                    return View(product1);
                }


            }
            else
            {
                return RedirectToAction("Index", "Error");
            }

        }

        [HttpPost]
        public async Task<IActionResult> ClickEditProduct(Product product, List<IFormFile> ImageFile)
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
                    if (ImageFile.Count == 0)
                    {
                        var productupdate = context.Products.Where(i => i.Productid == product.Productid).FirstOrDefault();
                        productupdate.Productname = product.Productname;
                        productupdate.Price = product.Price;
                        productupdate.Description = product.Description;
                        productupdate.Unitinstock = product.Unitinstock;
                        productupdate.Categoryid = product.Categoryid;

                        context.SaveChanges();
                        return RedirectToAction("Product", "Admin");
                    }
                    else
                    {

                        var productupdate = context.Products.Where(i => i.Productid == product.Productid).FirstOrDefault();
                        productupdate.Productname = product.Productname;
                        productupdate.Price = product.Price;
                        productupdate.Description = product.Description;
                        productupdate.Unitinstock = product.Unitinstock;
                        productupdate.Categoryid = product.Categoryid;
                        context.SaveChanges();


                        var images = context.Images.Where(i => i.Productid == product.Productid).ToList();
                        foreach (var i in images)
                        {
                            context.Images.Remove(i);

                            context.SaveChanges();
                        }
                    
                       
                       
                      

                        foreach (var i in ImageFile)
                        {

                            var lastproduct = context.Products.Where(s => s.Productid == productupdate.Productid).FirstOrDefault();
                            Image image = new Image();
                            image.Productid = lastproduct.Productid;
                            var filename = ContentDispositionHeaderValue.Parse(i.ContentDisposition).FileName.Trim('"');
                            var uniqueFileName = GetUniqueFileName(filename);
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", uniqueFileName);
                            using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                            {
                                await i.CopyToAsync(stream);
                            }
                            image.Imagelink = uniqueFileName;

                            context.Images.Add(image);

                            context.SaveChanges();
                        }




                    }
                    return RedirectToAction("Product", "Admin");

                }
            }
            else
            {
                return RedirectToAction("Index", "Error");
            }

            }



        }
    }

