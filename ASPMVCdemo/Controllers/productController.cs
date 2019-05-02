using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCdemo.Models;

namespace ASPMVCdemo.Controllers
{
    public class productController : Controller
    {
        public static List<Product> productList = new List<Product>();
        
        // GET: product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowProducts()
        {
            
            Product p1 = new Product("P01","Product 1",23.00,"ToothPaste");
            Product p2 = new Product("P02", "Product 2", 29.00, "Paste");
            Product p3 = new Product("P03", "Product 3", 34.00, "box");
            Product p4 = new Product("P04", "Product 4", 103.00, "Knife");
            if (productList.Count == 0)
            {
                productList.Add(p1);
                productList.Add(p2);
                productList.Add(p3);
                productList.Add(p4);
                
            }
            return View(productList);
        }

        //Add a user
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            productList.Add(p);
            return RedirectToAction("ShowProducts");
        }

        //Delete a User
        [HttpGet]
        public ActionResult Delete(string pid)
        {
            Product obj = productList.Find(x => x.Pid == pid);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Delete(string pid, FormCollection f1)
        {
            Product obj = productList.Find(x => x.Pid == pid);
            productList.Remove(obj);
            return RedirectToAction("ShowProducts");
        }

        //Show details of selected user'
        [HttpGet]
        public ActionResult Details(string pid)
        {
            Product obj = productList.Find(x => x.Pid == pid);
            return View(obj);
        }

        [HttpGet]
        public ActionResult Edit(string pid)
        {
            Product obj = productList.Find(x => x.Pid == pid);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(string pid, FormCollection f1)
        {
            Product obj = productList.Find(x => x.Pid == pid);
            obj.Pid = Request.Form["Pid"].ToString();
            obj.Name = Request.Form["Name"].ToString();
            obj.Price = double.Parse(Request.Form["Price"].ToString());
            obj.Description = Request.Form["Description"].ToString();
            return RedirectToAction("ShowProducts");
        }
    }
}