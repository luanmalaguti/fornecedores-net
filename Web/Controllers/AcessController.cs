using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.POCO;
using Context.DAO;
using Model.Util;
using Web.Models.Auth;

namespace Web.Controllers
{
    public class AcessController : Controller
    {
        private FornecedoresContext db = new FornecedoresContext();

        //
        // GET: /Acess/

        public ActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated && Session["userAccount"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        //
        // POST: /Access/Login

        [HttpPost]
        public ActionResult Index(Usuario model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (UserAuthentication.Authentication(model))
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                 }
            else
            {
                ModelState.AddModelError("failed", "The user name or password provided is incorrect.");
                return RedirectToAction("Index", "Acess");
            }
            return View(model);
        }
    }
}