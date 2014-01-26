using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;
using Context.DAO;
using Model;
using Model.POCO;

namespace Desktop.Controller
{
    public class UsuarioController : Controller<Usuario>
    {
        private FornecedoresContext db = ConnProvider.getContext();

        public Usuario Save(Usuario t)
        {
            if(t.Id == 0)
            {
                t = db.Usuario.Add(t);
            }
            else
            {
               db.Entry(t).State = EntityState.Modified;
            }

            db.SaveChanges();
            return t;
        }

        public void Remove(Usuario t)
        {
            db.Usuario.Remove(t);
            db.SaveChanges();
        }

        public Usuario Find(int id)
        {
            return db.Usuario.Find(id);
        }

        public ICollection<Usuario> FindAll()
        {
            return db.Usuario.ToList();
        }
    }
}
