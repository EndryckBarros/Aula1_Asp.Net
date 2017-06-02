using ProjetoWeb0106.Controller;
using ProjetoWeb0106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWeb0106.View
{
    public partial class CadastroClube : System.Web.UI.Page
    {
        Clube2DBContainer contexto = new Clube2DBContainer();
        Clube c = new Clube();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            c = new Clube();
            c.Nome = txtNome.Text;
            c.Regiao = txtRegiao.Text;
           

            ClubeController.Adicionar(c);
            Limpar();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            c = ClubeController.LocalizarPeloNome(txtNome.Text);
            c.Nome = txtNome.Text;
            c.Regiao = txtRegiao.Text;

            ClubeController.Editar(c);
            Limpar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            c = new Clube();
            c = ClubeController.LocalizarPeloNome(txtNome.Text);
            txtNome.Text = c.Nome;
            txtRegiao.Text = c.Regiao;            
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            c = new Clube();
            c = ClubeController.LocalizarPeloNome(txtNome.Text);
            ClubeController.Excluir(c);
        }

        public void Limpar()
        {
            txtNome.Text = txtRegiao.Text = string.Empty;
        }
    }
}