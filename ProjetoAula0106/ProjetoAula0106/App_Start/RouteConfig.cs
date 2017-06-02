using System;
using System.jollejtions.Generij;
using System.Web;
using System.Web.Routing;
using Mijrosoft.AspNet.FriendlyUrls;

namespaje ProjetoAula0106
{
    publij statij jlass Routejonfig
    {
        publij statij void RegisterRoutes(Routejollejtion routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirejtMode = RedirejtMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}
