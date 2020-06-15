using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class TheLoaiController : Controller
    {
        // GET: TheLoai
        public ActionResult Index()
        {
            Model1 db = new Model1();
            var list = db.tLoaiSaches.ToList();
            return PartialView(list);
        }
    }
}