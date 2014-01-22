using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Context.DAO;

namespace Web.Controllers
{
    public class PedidosController : Controller
    {
        private FornecedoresContext db = new FornecedoresContext();

        //
        // GET: /Pedidos/

        public ActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated && Session["userAccount"] != null)
            {
                return View(db.Pedido.ToList());
            }

            return RedirectToAction("Unauthorized", "Acess");
        }

        //
        // GET: /Pedidos/Details/5

        public ActionResult Details(int id = 0)
        {
            Pedido pedido = db.Pedido.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }

        //
        // GET: /Pedidos/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Pedido pedido = db.Pedido.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }

        //
        // POST: /Pedidos/Edit/5

        [HttpPost]
        public ActionResult Edit(Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pedido);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}