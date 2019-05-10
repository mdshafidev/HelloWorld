using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstEF.Models;

namespace CodeFirstEF.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDBContext dbContext = new ApplicationDBContext();
        public ActionResult Index()
        {
            Dept em = new Dept();
     
            em.DName = "HR";
            em.Date = DateTime.Now;
            em.DNameDescription = DateTime.Now;
            dbContext.Depts.Add(em);
            dbContext.SaveChanges();

            em.DName = "HR";
            em.Date = DateTime.Now;
            em.DNameDescription = DateTime.Now;
            dbContext.Depts.Add(em);
            dbContext.SaveChanges();

            var data = dbContext.Employees.ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
}