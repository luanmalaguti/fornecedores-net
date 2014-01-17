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
    public class ProdutosController : Controller
    {
        private FornecedoresContext db = new FornecedoresContext();
        private Usuario userSessao;
        private Fornecedor fornecedor;
        private ICollection<Produto> produtos;
        //
        // GET: /Produtos/

        public ActionResult Index()
        {     
            loadProdutos();
            return View(produtos.ToList());
        }

        //
        // GET: /Produtos/Details/5

        public ActionResult Details(int id = 0)
        {
            Produto produto = db.Produto.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        //
        // GET: /Produtos/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Produtos/Create

        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Produto.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produto);
        }

        //
        // GET: /Produtos/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Produto produto = db.Produto.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        //
        // POST: /Produtos/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            loadFornecedor();
            Produto produto = db.Produto.Find(id);
            fornecedor.Produtos.Remove(produto);
            db.Entry(fornecedor).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Adicionar()
        {
            return View(db.Produto.ToList());
        }

//        public ActionResult Adicionar(int id=0)
//        {
//            return View();
//        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public void loadProdutos()
        {
            loadFornecedor();
            produtos = fornecedor.Produtos;   
        }

        public void loadFornecedor()
        {
            userSessao = (Usuario)Session["userAccount"];
            fornecedor = db.Fornecedor.Where(f => f.Id == userSessao.Id).Include(p => p.Produtos).FirstOrDefault();
        }
    }
}