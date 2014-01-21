﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ICollection<FornecedorProduto> fornecedorProdutos;
        private ICollection<Produto> produtos = new Collection<Produto>();
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

            FornecedorProduto fp = 
                db.FornecedorProdutos.Where(f => f.FornecedorID == fornecedor.Id && f.ProdutoID == produto.Id).FirstOrDefault();

            fornecedor.FornecedorProduto.Remove(fp);

            db.Entry(fornecedor).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Adicionar()
        {
            loadFornecedor();
            produtos = db.Produto.ToList();
            //remove os produtos que o usuario já tem adicionado
            foreach (var fp in fornecedorProdutos)
            {
                if (fornecedor.Id == fp.FornecedorID)
                {
                    produtos.Remove(db.Produto.Find(fp.ProdutoID));    
                }
            }
            return View(produtos.ToList());
        }

        public ActionResult Add(int id=0)
        {
            loadFornecedor();
            
            FornecedorProduto fornecedorProduto = new FornecedorProduto();
            fornecedorProduto.Fornecedor = fornecedor;
            fornecedorProduto.Produto = db.Produto.Find(id);
            fornecedorProduto.ValorUnitario = 3;

            fornecedor.FornecedorProduto.Add(fornecedorProduto);

            db.Entry(fornecedor).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public void loadProdutos()
        {
            loadFornecedor();
            
            foreach (var fp in fornecedorProdutos)
            {
                produtos.Add(db.Produto.Find(fp.ProdutoID));    
            }
        }

        public void loadFornecedor()
        {
            userSessao = (Usuario)Session["userAccount"];
            fornecedor = db.Fornecedor.Where(f => f.Id == userSessao.Id).Include(f => f.FornecedorProduto).FirstOrDefault();
            fornecedorProdutos = fornecedor.FornecedorProduto;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}