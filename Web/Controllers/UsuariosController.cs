using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.POCO;
using Context.DAO;
using Web.Models.Auth;

namespace Web.Controllers
{
    public class UsuariosController : Controller
    {
        private FornecedoresContext db = new FornecedoresContext();
        
        //
        // GET: /Usuarios/

        public ActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated && UserAuthorization.IsAdmin())
            {
                return View(db.Usuario.Where(f => !f.Admin).Include(f => f.Fornecedor).ToList());
            }

            return RedirectToAction("Unauthorized", "Acess");
        }

        //
        // GET: /Usuarios/Details/5

        public ActionResult Details(int id = 0)
        {
            //Forçando cascata para carregar o objeto fornecedor
            Usuario usuario = db.Usuario.Where(u => u.Id == id).Include(f => f.Fornecedor).FirstOrDefault(); 
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        //
        // GET: /Usuarios/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Usuarios/Create

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
        // GET: /Usuarios/Edit/5

        public ActionResult Edit(int id = 0)
        {
            //Forçando cascata para carregar o objeto fornecedor
            Usuario usuario = db.Usuario.Where(u => u.Id == id).Include(f => f.Fornecedor).FirstOrDefault();
            if (usuario == null)
            {
                //se não esta editando um usuario da lista, então é o fornecedor editando a propria conta
                Usuario userSessao = (Usuario)Session["userAccount"];
                usuario = db.Usuario.Where(u => u.Id == userSessao.Id).Include(f => f.Fornecedor).FirstOrDefault();
            }
            return View(usuario);
        }

        //
        // POST: /Usuarios/Edit/5

        [HttpPost]
        public ActionResult Edit(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();

                if (!UserAuthorization.IsAdmin())
                    return RedirectToAction("Index", "Home");

                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        //
        // GET: /Usuarios/Delete/5

        public ActionResult Delete(int id = 0)
        {
            //Forçando cascata para carregar o objeto fornecedor
            Usuario usuario = db.Usuario.Where(u => u.Id == id).Include(f => f.Fornecedor).FirstOrDefault();
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        //
        // POST: /Usuarios/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //Forçando cascata para carregar o objeto fornecedor
            Usuario usuario = db.Usuario.Where(u => u.Id == id).Include(f => f.Fornecedor).FirstOrDefault();
            db.Usuario.Remove(usuario);
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