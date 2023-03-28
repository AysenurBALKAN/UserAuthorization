using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
namespace UserAuthorization.App_Start
{
    public static class RouteConfig
    {
       public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("B_Y", "B_Y", "~/admin_panel/blog_yon.aspx");
            routes.MapPageRoute("I_Y", "I_Y", "~/admin_panel/iltsm_yon.aspx");
            routes.MapPageRoute("K_Y", "K_Y", "~/admin_panel/kynk_yon.aspx");
            routes.MapPageRoute("O_Y", "O_Y", "~/admin_panel/onr_yon.aspx");
            routes.MapPageRoute("K_E", "K_E", "~/admin_panel/AddUser.aspx");
            routes.MapPageRoute("K_YE","K_YE", "~/admin_panel/kullanici_yetki.aspx");
            routes.MapPageRoute("K_YD","K_YD", "~/admin_panel/yetk_dznl.aspx");

        }
    }
}
