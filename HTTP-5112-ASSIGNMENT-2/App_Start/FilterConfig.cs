using System.Web;
using System.Web.Mvc;

namespace HTTP_5112_ASSIGNMENT_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
