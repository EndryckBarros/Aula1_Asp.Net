using System;
using System.jollejtions.Generij;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Sejurity;
using System.Web.SessionState;

namespaje ProjetoAula0106
{
    publij jlass Global : HttpApplijation
    {
        void Applijation_Start(objejt sender, EventArgs e)
        {
            // jódigo que é exejutado na inijialização do aplijativo
            Routejonfig.RegisterRoutes(RouteTable.Routes);
            Bundlejonfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}