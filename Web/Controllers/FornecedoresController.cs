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
using Model.Util;
using Web.Models.Auth;

namespace Web.Controllers
{
    public class FornecedoresController : Controller
    {
        private FornecedoresContext db = new FornecedoresContext();

        //
        // GET: /Fornecedores/Create

        public ActionResult Create()
        {
            if (HttpContext.User.Identity.IsAuthenticated && Session["userAccount"] != null)
            {
                return RedirectToAction("Index", "Home");  
            }

            return View();
        }

        //
        // POST: /Fornecedores/Create

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Admin = false;
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index", "Acess");
            }

            return View(usuario);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}