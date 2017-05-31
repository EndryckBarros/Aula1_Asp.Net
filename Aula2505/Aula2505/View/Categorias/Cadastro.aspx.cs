using Aula2505.Controller;
using Aula2505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505.View.Categorias
{
    public partial class Cadastro : System.Web.UI.Page
    {
        BaseDadosContainer contexto = new BaseDadosContainer();
        Categoria c = new Categoria();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            c = new Categoria();
            c.Nome = txtNome.Text;
            c.Descricao = txtDescricao.Text;
            c.Ativo = cbAtivo.Checked;

            CategoriaController.Adicionar(c);
            txtDescricao.Text = txtNome.Text = string.Empty;
            cbAtivo.Checked = false;

            Limpar();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            c = CategoriaController.LocalizarPeloNome(txtNome.Text);
            c.Nome = txtNome.Text;
            c.Descricao = txtDescricao.Text;
            c.Ativo = cbAtivo.Checked;

            CategoriaController.Editar(c);
            Limpar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            c = new Categoria();
            c = CategoriaController.LocalizarPeloNome(txtNome.Text);
            txtNome.Text = c.Nome;
            txtDescricao.Text = c.Descricao;
            cbAtivo.Checked = c.Ativo;
        }
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            c = new Categoria();
            c = CategoriaController.LocalizarPeloNome(txtNome.Text);
            CategoriaController.Excluir(c);
        }




        public void Limpar()
        {
            txtDescricao.Text = txtNome.Text = string.Empty;
            cbAtivo.Checked = false;
        }

    }
}