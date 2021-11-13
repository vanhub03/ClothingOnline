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
        ProjectPRN211Context context = new ProjectPRN211Context();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewInforToCheckOut()
        {
            return View();
        }
        public IActionResult AccountInfoToCheckOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddToOrder(Order order)
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString("cart");
            var account = JsonConvert.DeserializeObject<Account>(session.GetString("accountSession"));
            List<Cart> carts = new List<Cart>();
            double total = 0;
            if (jsoncart != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(jsoncart);
            }
            foreach(var item in carts)
            {
                double price = item.product.Price * item.quantity;
                total += price;
            }
            order.Accountid = account.Userid;
            order.Status = 2;
            order.CreatedDate = DateTime.Now;
            order.Totalprice = total.ToString();
            context.Orders.Add(order);
            context.SaveChanges();
            int count = 0;
                foreach (var item in carts)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderId = order.Orderid;
                    orderDetail.Productid = item.product.Productid;
                    orderDetail.Quantity = item.quantity;
                    orderDetail.UnitPrice = item.product.Price;
                    context.OrderDetails.Add(orderDetail);
                    count = context.SaveChanges();
            }
            if (count > 0)
            {
                session.Remove(jsoncart);
                return RedirectToAction("listproduct", "product");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult AddToOrderWithAccountInfor()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString("cart");
            var account = JsonConvert.DeserializeObject<Account>(session.GetString("accountSession"));
            List<Cart> carts = new List<Cart>();
            Order order = new Order();
            double total = 0;
            if (jsoncart != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(jsoncart);
            }
            foreach (var item in carts)
            {
                double price = item.product.Price * item.quantity;
                total += price;
            }
            order.Accountid = account.Userid;
            order.Status = 2;
            order.CreatedDate = DateTime.Now;
            order.Totalprice = total.ToString();
            order.Address = account.Address;
            order.Phone = account.Phone;
            order.Customername = account.Username;
            context.Orders.Add(order);
            context.SaveChanges();
            int count = 0;
            foreach (var item in carts)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderId = order.Orderid;
                orderDetail.Productid = item.product.Productid;
                orderDetail.Quantity = item.quantity;
                orderDetail.UnitPrice = item.product.Price;
                context.OrderDetails.Add(orderDetail);
                count = context.SaveChanges();
            }
            if (count > 0)
            {
                session.Remove("cart");
                return RedirectToAction("listproduct", "product");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult ViewOrderByAccountId(int id)
        {
            var orders = context.Orders.Where(o => o.Accountid == id).ToList();
            foreach (var order in orders)
            {
                var orderdetails = context.OrderDetails.Where(o => o.OrderId == order.Orderid).ToList();
                foreach(var orderdetail in orderdetails)
                {
                    var product = context.Products.Find(orderdetail.Productid);
                    orderdetail.Product = product;
                    order.OrderDetails.Add(orderdetail);
                }
            }
            return View(orders);
        }
    }
}
