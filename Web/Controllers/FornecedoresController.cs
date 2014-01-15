using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Context.DAO;
using Model.POCO;

namespace Web.Controllers
{
    public class FornecedoresController : Controller
    {
        private FornecedoresContext db = new FornecedoresContext();

        //
        // GET: /Fornecedores/

        public ActionResult Index()
        {
            return View(db.Fornecedor.ToList());
        }

        //
        // GET: /Fornecedores/Details/5

        public ActionResult Details(int id = 0)
        {
            Fornecedor fornecedor = db.Fornecedor.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        //
        // GET: /Fornecedores/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Fornecedores/Create

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        //
        // GET: /Fornecedores/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Fornecedor fornecedor = db.Fornecedor.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        //
        // POST: /Fornecedores/Edit/5

        [HttpPost]
        public ActionResult Edit(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fornecedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        //
        // GET: /Fornecedores/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Fornecedor fornecedor = db.Fornecedor.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        //
        // POST: /Fornecedores/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Fornecedor fornecedor = db.Fornecedor.Find(id);
            db.Fornecedor.Remove(fornecedor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}