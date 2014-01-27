using System;
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
using Model.Util;

namespace Web.Controllers
{
    public class PedidosController : Controller
    {
        private FornecedoresContext db = new FornecedoresContext();
        private Usuario userSessao;
        private Fornecedor fornecedor;

        //
        // GET: /Pedidos/

        public ActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated && Session["userAccount"] != null)
            {
                return View(LoadPedidos());
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

            pedido = LoadProdutos(pedido);
            
            return View(pedido);
        }

        //
        // GET: /Pedidos/Edit/5

        public ActionResult Edit(StatusPedido status = 0, int id = 0)
        {
            
            if (status == 0)
            {
                return HttpNotFound();
            }

            Pedido pedido = db.Pedido.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }

            pedido.Status = status;
            db.Entry(pedido).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public Pedido LoadProdutos(Pedido pedido)
        {
            ICollection<ItemPedido> Load = new Collection<ItemPedido>(); 
            
            foreach (var p in pedido.ItemsPedido)
            {
                ItemPedido itemPedido = new ItemPedido();
                itemPedido = p;
                itemPedido.Produto = db.Produto.Find(p.ProdutoID);
                Load.Add(itemPedido);
            }
            
            pedido.ItemsPedido = Load;

            return pedido;
        }

        public List<Pedido> LoadPedidos()
        {
            LoadFornecedor();
            return fornecedor.Pedidos.ToList();
        }

        public void LoadFornecedor()
        {
            userSessao = (Usuario)Session["userAccount"];
            fornecedor = db.Fornecedor.Where(f => f.Id == userSessao.Fornecedor.Id).Include(f => f.Pedidos).FirstOrDefault();
        }
    }

}