
using Model.Util;

namespace Web.Models.Auth
{
    public class UserAuthorization
    {
        public static bool IsAdmin()
        {
            return System.Web.HttpContext.Current.Session["admin"] != null;
        }
    }
}