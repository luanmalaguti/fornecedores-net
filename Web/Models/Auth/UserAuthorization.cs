
using Model.Util;

namespace Web.Models.Auth
{
    public class UserAuthorization
    {
        public static bool IsAuthorized(Tipo tipo)
        {
            switch (tipo)
            {
                case(Tipo.ADMIN):
                    return System.Web.HttpContext.Current.Session["tipoUsuario"].Equals(TipoUsuario.ADMIN);
                
                case (Tipo.FORNECEDOR):
                    return System.Web.HttpContext.Current.Session["tipoUsuario"].Equals(TipoUsuario.FORNECEDOR);
            }
            return false;
        }

        public enum Tipo
        {
            ADMIN,
            FORNECEDOR
        }
    }
}