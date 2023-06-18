using System.Web;
using System.Web.Mvc;

namespace Violet_Roberston_RoomBooking.YM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
