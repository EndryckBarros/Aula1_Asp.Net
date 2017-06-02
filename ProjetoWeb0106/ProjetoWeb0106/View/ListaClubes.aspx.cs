using ProjetoWeb0106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWeb0106.View
{
    public partial class ListaClubes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Clube2DBContainer contexto = new Clube2DBContainer();

            var Clubes = contexto.Clubes;

            gvClubes.DataSource = Clubes.ToList();
            gvClubes.DataBind();
        }
    }
}