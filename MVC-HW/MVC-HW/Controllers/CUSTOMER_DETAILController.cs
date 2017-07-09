using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_HW.Models;

namespace MVC_HW.Controllers
{
    public class CUSTOMER_DETAILController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: CUSTOMER_DETAIL
        public ActionResult Index()
        {
            return View(db.CUSTOMER_DETAIL.ToList());
        }

        //// GET: CUSTOMER_DETAIL/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CUSTOMER_DETAIL cUSTOMER_DETAIL = db.CUSTOMER_DETAIL.Find(id);
        //    if (cUSTOMER_DETAIL == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(cUSTOMER_DETAIL);
        //}

        //// GET: CUSTOMER_DETAIL/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: CUSTOMER_DETAIL/Create
        //// 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        //// 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "客戶名稱,聯絡人數量,銀行帳戶數量")] CUSTOMER_DETAIL cUSTOMER_DETAIL)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.CUSTOMER_DETAIL.Add(cUSTOMER_DETAIL);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(cUSTOMER_DETAIL);
        //}

        //// GET: CUSTOMER_DETAIL/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CUSTOMER_DETAIL cUSTOMER_DETAIL = db.CUSTOMER_DETAIL.Find(id);
        //    if (cUSTOMER_DETAIL == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(cUSTOMER_DETAIL);
        //}

        //// POST: CUSTOMER_DETAIL/Edit/5
        //// 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        //// 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "客戶名稱,聯絡人數量,銀行帳戶數量")] CUSTOMER_DETAIL cUSTOMER_DETAIL)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(cUSTOMER_DETAIL).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(cUSTOMER_DETAIL);
        //}

        //// GET: CUSTOMER_DETAIL/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CUSTOMER_DETAIL cUSTOMER_DETAIL = db.CUSTOMER_DETAIL.Find(id);
        //    if (cUSTOMER_DETAIL == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(cUSTOMER_DETAIL);
        //}

        //// POST: CUSTOMER_DETAIL/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    CUSTOMER_DETAIL cUSTOMER_DETAIL = db.CUSTOMER_DETAIL.Find(id);
        //    db.CUSTOMER_DETAIL.Remove(cUSTOMER_DETAIL);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
