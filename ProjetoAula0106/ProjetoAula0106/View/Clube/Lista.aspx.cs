
using ProjetoAula0106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505.View.Clubes
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BaseDadosContainer contexto = new BaseDadosContainer();

            var Clubes = contexto.ClubeSet;

            gvClubes.DataSource = Clubes.ToList();
            gvClubes.DataBind();
        }
    }
}