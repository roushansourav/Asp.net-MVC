using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCdemo.Models;

namespace ASPMVCdemo.Controllers
{
    public class userController : Controller
    {
        public static List<User> userList = new List<User>();
        // GET: user
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowUsers()
        {
            User u1 = new User { Name = "Roushan Sourav", Age = 24, City="Ranchi"};
            
            User u2 = new User();
            u2.Name = "Shishir Sourav";
            u2.Age = 24;
            u2.City = "Ranchi";
            User u3 = new User();
            u3.Name = "Ramnik Sourav";
            u3.Age = 24;
            u3.City = "Ranchi";
            User u4 = new User();
            u4.Name = "Shashank Saurav";
            u4.Age = 24;
            u4.City = "Ranchi";
            if (userList.Count == 0)
            {
                userList.Add(u1);
                userList.Add(u2);
                userList.Add(u3);
                userList.Add(u4);
            }
            return View(userList);

        }
        //Add a user
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User u5)
        {
            userList.Add(u5);
            return RedirectToAction("ShowUsers");
        }

        //Delete a User
        [HttpGet]
        public ActionResult Delete(string str)
        {
            User obj = userList.Find(x => x.Name == str);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Delete(string str,FormCollection f1)
        {
            User obj = userList.Find(x => x.Name == str);
            userList.Remove(obj);
            return RedirectToAction("ShowUsers");
        }

        //Show details of selected user'
        [HttpGet]
        public ActionResult Details(string str)
        {
            User obj = userList.Find(x => x.Name == str);
            return View(obj);
        }

        [HttpGet]
        public ActionResult Edit(string s)
        {
            User obj = userList.Find(x => x.Name == s);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(string s,FormCollection f1)
        {
            User obj = userList.Find(x => x.Name == s);
            obj.Name = Request.Form["Name"].ToString();
            obj.City = Request.Form["City"].ToString();
            obj.Age = int.Parse(Request.Form["Age"].ToString());
            return RedirectToAction("ShowUsers");
        }

    }
}