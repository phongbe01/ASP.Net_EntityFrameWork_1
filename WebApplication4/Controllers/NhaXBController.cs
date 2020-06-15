using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class NhaXBController : Controller
    {
        // GET: NhaXB
        public ActionResult Index()
        {
            Model1 db = new Model1();
            var list = db.tNhaXBs.Take(5).ToList();
            return PartialView(list);
        }
    }
}