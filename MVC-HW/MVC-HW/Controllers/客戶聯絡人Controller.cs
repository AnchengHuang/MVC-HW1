using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_HW.Models;
using PagedList;

namespace MVC_HW.Controllers
{
    public class 客戶聯絡人Controller : BaseController
    {
        //private 客戶資料Entities db = new 客戶資料Entities();

        // GET: 客戶聯絡人
        public ActionResult Index(int pageNo = 1)
        {
            var 客戶聯絡人 = 客戶聯絡人repo.取得未刪除資料().OrderBy(x=>x.姓名);
            var data = 客戶聯絡人.ToPagedList(pageNo, pageSize);
            return View(data);
        }

        // GET: 客戶聯絡人/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶聯絡人 客戶聯絡人 = 客戶聯絡人repo.Find(id.Value);
            if (客戶聯絡人 == null)
            {
                return HttpNotFound();
            }
            return View(客戶聯絡人);
        }

        // GET: 客戶聯絡人/Create
        public ActionResult Create()
        {
            ViewBag.客戶Id = new SelectList(客戶資料repo.取得未刪除資料(), "Id", "客戶名稱");
            return View();
        }

        // POST: 客戶聯絡人/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,客戶Id,職稱,姓名,Email,手機,電話,is_del")] 客戶聯絡人 客戶聯絡人)
        {
            var is_exist = 客戶聯絡人repo.Where(x => x.客戶Id == 客戶聯絡人.客戶Id && x.Email == 客戶聯絡人.Email).ToList();

            if (!is_exist.Any())
            {
                if (ModelState.IsValid)
                {
                    客戶聯絡人repo.Add(客戶聯絡人);
                    客戶聯絡人repo.UnitOfWork.Commit();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                ModelState.AddModelError("Email", "信箱重複");
            }

            ViewBag.客戶Id = new SelectList(客戶資料repo.取得未刪除資料(), "Id", "客戶名稱", 客戶聯絡人.客戶Id);
            return View(客戶聯絡人);
        }

        // GET: 客戶聯絡人/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶聯絡人 客戶聯絡人 = 客戶聯絡人repo.Find(id.Value);
            if (客戶聯絡人 == null)
            {
                return HttpNotFound();
            }
            ViewBag.客戶Id = new SelectList(客戶資料repo.取得未刪除資料(), "Id", "客戶名稱", 客戶聯絡人.客戶Id);
            return View(客戶聯絡人);
        }

        // POST: 客戶聯絡人/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,客戶Id,職稱,姓名,Email,手機,電話,is_del")] 客戶聯絡人 客戶聯絡人)
        {
            var is_exist = 客戶聯絡人repo.Where(x => x.Id != 客戶聯絡人.Id && x.客戶Id == 客戶聯絡人.客戶Id && x.Email == 客戶聯絡人.Email).ToList();

            if (!is_exist.Any())
            {
                if (ModelState.IsValid)
                {
                    客戶聯絡人repo.UnitOfWork.Context.Entry(客戶聯絡人).State = EntityState.Modified;
                    客戶聯絡人repo.UnitOfWork.Commit();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                ModelState.AddModelError("Email", "信箱重複");
            }
            ViewBag.客戶Id = new SelectList(客戶資料repo.取得未刪除資料(), "Id", "客戶名稱", 客戶聯絡人.客戶Id);
            return View(客戶聯絡人);
        }

        // GET: 客戶聯絡人/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶聯絡人 客戶聯絡人 = 客戶聯絡人repo.Find(id.Value);
            if (客戶聯絡人 == null)
            {
                return HttpNotFound();
            }
            return View(客戶聯絡人);
        }

        // POST: 客戶聯絡人/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            客戶聯絡人repo.delete(id);

            return RedirectToAction("Index");
        }

        public ActionResult Search(string query, int pageNo = 1)
        {
            var result = 客戶聯絡人repo.Where(x => x.姓名.Contains(query) && x.is_del == false).ToList();
            var data = result.ToPagedList(pageNo, pageSize);

            return View(data);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
