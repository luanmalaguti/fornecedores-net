using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using Context.DAO;
using Model.POCO;

namespace Web.Models.Auth
{
    public class UserAuthentication
    {
        private static FornecedoresContext db = new FornecedoresContext();

        public static bool Authentication(Usuario usuario)
        {
            var parms = new SqlParameter[2];
            parms[0] = new SqlParameter("p0", usuario.Username);
            parms[1] = new SqlParameter("p1", usuario.Password);

            DbSqlQuery<Usuario> query = db.Usuario.SqlQuery("Select * from Usuario where " +
              "username=@p0 and password=@p1", parms);

            if (query.Any())
            {
                FormsAuthentication.SetAuthCookie(usuario.Username, true);
                System.Web.HttpContext.Current.Session["UserAccount"] = usuario;
                System.Web.HttpContext.Current.Session["tipoUsuario"] = usuario.TipoUsuario;
                
                return true;
            }

            return false;
        }
    }
}