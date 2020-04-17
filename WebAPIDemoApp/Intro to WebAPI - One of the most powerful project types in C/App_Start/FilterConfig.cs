using System.Web;
using System.Web.Mvc;

namespace Intro_to_WebAPI___One_of_the_most_powerful_project_types_in_C
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
