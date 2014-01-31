using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Context.DAO;
using Model;
using WebService.Models;

namespace WebService.Controllers
{
    public class FornecedoresController : IController<Fornecedor, FornecedorDB>
    {
        private FornecedoresContext db = ConnProvider.getContext();
        
        public FornecedorDB[] getAll()
        {
            List<FornecedorDB> fornecedoresDb = new List<FornecedorDB>();

            List<Fornecedor> fornecedores = db.Fornecedor.ToList();

            foreach (var f in fornecedores)
            {
                fornecedoresDb.Add(ToDataMember(f));
            }

            return fornecedoresDb.ToArray();
        }

        public FornecedorDB ToDataMember(Fornecedor t)
        {
            throw new NotImplementedException();
        }
    }
}