using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCdemo.Models;

namespace ASPMVCdemo.Controllers
{
    public class studentController : Controller
    {
        public static List<Student> studentList = new List<Student>();
        // GET: student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowStudents()
        {
            //List < Student > studentList= new List<Student>();
            Student s1 = new Student { Stid = "S01", Name = "Student1", Sem = "1" };
            Student s2 = new Student { Stid = "S02", Name = "Student2", Sem = "1" };
            Student s3 = new Student { Stid = "S03", Name = "Student3", Sem = "1" };
            Student s4 = new Student { Stid = "S04", Name = "Student4", Sem = "1" };
            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);
            studentList.Add(s4);
            return View(studentList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Student s)
        {
            studentList.Add(s);
            return RedirectToAction("ShowStudents");
        }
        
    }
}