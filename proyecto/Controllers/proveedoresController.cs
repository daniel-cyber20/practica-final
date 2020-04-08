﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proyecto.Models;
using Rotativa;
namespace proyecto.Controllers
{
    public class proveedoresController : Controller
    {
        private productoContext db = new productoContext();

        // GET: proveedores
        public ActionResult Index()
        {
            return View(db.proveedore.ToList());
        }
        public ActionResult imprimir()
        {
            var print = new ActionAsPdf("Index");
            return print;
        }

        // GET: proveedores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            proveedores proveedores = db.proveedore.Find(id);
            if (proveedores == null)
            {
                return HttpNotFound();
            }
            return View(proveedores);
        }

        // GET: proveedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: proveedores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,cedula,nombre,telefono,email")] proveedores proveedores)
        {
            if (ModelState.IsValid)
            {
                db.proveedore.Add(proveedores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proveedores);
        }

        // GET: proveedores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            proveedores proveedores = db.proveedore.Find(id);
            if (proveedores == null)
            {
                return HttpNotFound();
            }
            return View(proveedores);
        }

        // POST: proveedores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,cedula,nombre,telefono,email")] proveedores proveedores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proveedores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proveedores);
        }

        // GET: proveedores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            proveedores proveedores = db.proveedore.Find(id);
            if (proveedores == null)
            {
                return HttpNotFound();
            }
            return View(proveedores);
        }

        // POST: proveedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            proveedores proveedores = db.proveedore.Find(id);
            db.proveedore.Remove(proveedores);
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
