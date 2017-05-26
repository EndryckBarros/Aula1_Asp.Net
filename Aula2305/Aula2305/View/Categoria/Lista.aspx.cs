
using Aula2305.Models;
using System;
using System.Linq;

namespace Aula2305.View.Categoria
{
    public partial class Lista : BasePage //System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LojaDBEntities contexto = new LojaDBEntities();
            gvCategorias.DataSource = contexto.Categoria.ToList();

            gvCategorias.DataBind();
        }
    }
}