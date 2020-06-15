using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using PagedList;
using PagedList.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();

        // GET: Home
        public ActionResult Index(int? page)
        {
            int pageSize = 20;
            int pageNumber = (page ?? 1);
            var tSaches = db.tSaches.ToList().ToPagedList(pageNumber, pageSize);
            return View(tSaches);
        }

        public ActionResult SPTheoTheLoai(string id, int? page)
        {
            int pageSize = 20;
            int pageNumber = (page ?? 1);
            var tSaches = db.tSaches.Where(x => x.MaLoai == id).ToList().ToPagedList(pageNumber, pageSize);
            return View(tSaches);
        }

        public ActionResult SPTheoNXB(string id, int? page)
        {
            int pageSize = 20;
            int pageNumber = (page ?? 1);
            var tSaches = db.tSaches.Where(x => x.MaNXB == id).ToList().ToPagedList(pageNumber, pageSize);
            return View(tSaches);
        }

        // GET: Home/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tSach tSach = db.tSaches.Find(id);
            if (tSach == null)
            {
                return HttpNotFound();
            }
            return View(tSach);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(db.tLoaiSaches, "MaLoai", "TenLoai");
            ViewBag.MaNgonNgu = new SelectList(db.tNgonNgus, "MaNgonNgu", "TenNgonNgu");
            ViewBag.MaNXB = new SelectList(db.tNhaXBs, "MaNXB", "TenNXB");
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSach,TenSach,MaLoai,MaNgonNgu,MaNXB,TacGia,NamXB,LanXB,GioiThieu,TongSoTrang,Tap,TongSoTap,GiaTriSach,FileAnh")] tSach tSach)
        {
            if (ModelState.IsValid)
            {
                db.tSaches.Add(tSach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLoai = new SelectList(db.tLoaiSaches, "MaLoai", "TenLoai", tSach.MaLoai);
            ViewBag.MaNgonNgu = new SelectList(db.tNgonNgus, "MaNgonNgu", "TenNgonNgu", tSach.MaNgonNgu);
            ViewBag.MaNXB = new SelectList(db.tNhaXBs, "MaNXB", "TenNXB", tSach.MaNXB);
            return View(tSach);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tSach tSach = db.tSaches.Find(id);
            if (tSach == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoai = new SelectList(db.tLoaiSaches, "MaLoai", "TenLoai", tSach.MaLoai);
            ViewBag.MaNgonNgu = new SelectList(db.tNgonNgus, "MaNgonNgu", "TenNgonNgu", tSach.MaNgonNgu);
            ViewBag.MaNXB = new SelectList(db.tNhaXBs, "MaNXB", "TenNXB", tSach.MaNXB);
            return View(tSach);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSach,TenSach,MaLoai,MaNgonNgu,MaNXB,TacGia,NamXB,LanXB,GioiThieu,TongSoTrang,Tap,TongSoTap,GiaTriSach,FileAnh")] tSach tSach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tSach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoai = new SelectList(db.tLoaiSaches, "MaLoai", "TenLoai", tSach.MaLoai);
            ViewBag.MaNgonNgu = new SelectList(db.tNgonNgus, "MaNgonNgu", "TenNgonNgu", tSach.MaNgonNgu);
            ViewBag.MaNXB = new SelectList(db.tNhaXBs, "MaNXB", "TenNXB", tSach.MaNXB);
            return View(tSach);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tSach tSach = db.tSaches.Find(id);
            if (tSach == null)
            {
                return HttpNotFound();
            }
            return View(tSach);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tSach tSach = db.tSaches.Find(id);
            db.tSaches.Remove(tSach);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
