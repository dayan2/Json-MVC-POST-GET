using System.Web;
using System.Web.Mvc;

namespace Axaj_Add_Confirmation_jquery_part2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
