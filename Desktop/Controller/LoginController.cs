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
        private FornecedoresContext db = ConnProvider.getContext();

        public bool Login(string username, string password)
        {
            Usuario usuario = db.Usuario.FirstOrDefault(u => u.Username == username && u.Password == password);
            
            return (usuario != null && usuario.Admin);
        }
    }
}
