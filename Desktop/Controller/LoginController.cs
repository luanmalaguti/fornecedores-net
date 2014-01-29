using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;
using Context.DAO;
using Model.POCO;

namespace Desktop.Controller
{
    public class LoginController
    {
        public Usuario usuario { get; set; }
        private FornecedoresContext db = ConnProvider.getContext();

        public LoginController()
        {
            Usuario u = null;
 
            if(!db.Database.Exists())
            {
                u = new Usuario();
                u.Username = "admin";
                u.Password = "admin";
                u.Admin = true;
            }

            db.Database.CreateIfNotExists();

            // cria o usuario padrao se o banco é novo
            if (u != null)
            {
                db.Usuario.Add(u);
                db.SaveChanges();
            }
        }

        public bool Login(string username, string password)
        {
            usuario = db.Usuario.FirstOrDefault(u => u.Username == username && u.Password == password);
  
            return (usuario != null && usuario.Admin);
        }
       
    }
}
