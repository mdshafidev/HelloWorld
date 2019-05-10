using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEF.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewModel o1 = new ViewModel();
            o1.Id = 10;
            var o1Id = o1.Id;
            ViewModel o2 = new ViewModel();
            o2 = o1;
            var o2Id = o2.Id;
            o1.Id = 20;
            var o2Id2 = o2.Id;
            var o1Id2 = o1.Id;
            return View();
        }

        [HttpPost]
        public ActionResult Save(Employee model)
        {
            return View("About");
        }

        [HttpPost]
        public ActionResult Cancel(Employee model)
        {
            return View("About");
        }
    }
}