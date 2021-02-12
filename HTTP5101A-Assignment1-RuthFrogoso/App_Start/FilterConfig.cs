using System.Web;
using System.Web.Mvc;

namespace HTTP5101A_Assignment1_RuthFrogoso
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
