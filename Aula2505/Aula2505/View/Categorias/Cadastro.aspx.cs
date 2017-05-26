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
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria();

            c.Nome = txtNome.Text;
            c.Descricao = txtDescricao.Text;
            c.Ativo = cbAtivo.Checked;
            contexto.Categorias.Add(c);
            contexto.SaveChanges();

            txtDescricao.Text = txtNome.Text = string.Empty;
            cbAtivo.Checked = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = txtNome.Text = string.Empty;
            cbAtivo.Checked = false;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Categoria c = Buscar(txtNome.Text);
            contexto.Entry(c).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public Categoria Buscar(string nome)
        {
            return contexto.Categorias.FirstOrDefault(x => x.Nome.Equals(nome));

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Categoria c = Buscar(txtNome.Text);
            txtNome.Text = c.Nome;
            txtDescricao.Text = c.Descricao;
            cbAtivo.Checked = c.Ativo;
        }
    }
}