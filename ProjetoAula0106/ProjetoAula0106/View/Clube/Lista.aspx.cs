
using ProjetoAula0106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505.View.Jogadors
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BaseDadosContainer contexto = new BaseDadosContainer();

            var Jogadors = contexto.Jogadors;

            gvJogadors.DataSource = Jogadors.ToList();
            gvJogadors.DataBind();
        }
    }
}