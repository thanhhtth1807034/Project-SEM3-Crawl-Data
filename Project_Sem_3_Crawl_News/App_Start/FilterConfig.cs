using System.Web;
using System.Web.Mvc;

namespace Project_Sem_3_Crawl_News
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
