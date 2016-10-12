using System.Web;
using System.Web.Mvc;

namespace WWT.StealToe.Configuration.DotNetFramework4_6_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
