using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolProject.Models;

namespace SchoolProject.Controllers
{
    public class CMS_MenuController : ApplicationController
    {
        // GET: CMS_Menu
        public ActionResult Index()
        {
            return View(db.CMS_Menu.OrderBy(a=>a.MenuOrder));
        }

        // GET: CMS_Menu/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CMS_Menu cMS_Menu = db.CMS_Menu.Find(id);
            if (cMS_Menu == null)
            {
                return HttpNotFound();
            }
            return View(cMS_Menu);
        }

        // GET: CMS_Menu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CMS_Menu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,URL,Description,DateCreated,UserCreated")] CMS_Menu cMS_Menu)
        {
            if (ModelState.IsValid)
            {
               // CMS_Site site = db.CMS_Site.FirstOrDefault();
                cMS_Menu.Id = Guid.NewGuid();
                db.CMS_Menu.Add(cMS_Menu);
             //   db.CMS_Menu.CMS_Site.Add(site);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cMS_Menu);
        }

        // GET: CMS_Menu/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CMS_Menu cMS_Menu = db.CMS_Menu.Find(id);
            if (cMS_Menu == null)
            {
                return HttpNotFound();
            }
            return View(cMS_Menu);
        }

        // POST: CMS_Menu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,URL,Description,DateCreated,UserCreated")] CMS_Menu cMS_Menu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cMS_Menu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cMS_Menu);
        }

        // GET: CMS_Menu/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CMS_Menu cMS_Menu = db.CMS_Menu.Find(id);
            if (cMS_Menu == null)
            {
                return HttpNotFound();
            }
            return View(cMS_Menu);
        }

        // POST: CMS_Menu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            CMS_Menu cMS_Menu = db.CMS_Menu.Find(id);
            db.CMS_Menu.Remove(cMS_Menu);
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
