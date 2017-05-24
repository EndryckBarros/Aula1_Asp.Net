using Aula2305.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2305.View.Produto
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CONTEXTO -- REFERENCIA PARA O BANCO DE DADOS
            //LojaDBEntities contexto = new LojaDBEntities();
            gvProdutos.DataSource = contexto.Produto.ToList();

            gvProdutos.DataBind();
        }
    }
}