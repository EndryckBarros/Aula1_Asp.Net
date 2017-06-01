
using ProjetoAula0106.Controller;
using ProjetoAula0106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505.View.Clubes
{
    public partial class Cadastro : System.Web.UI.Page
    {
        BaseDadosContainer contexto = new BaseDadosContainer();
        Clube c = new Clube();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            c = new Clube();
            c.Jogador = txtJogador.Text;
            c.Posicao = txtPosicao.Text;
            c.NumeroCamisa = txtNumeroCamisa.Text;           

            ClubeController.Adicionar(c);
            Limpar();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            c = ClubeController.LocalizarPeloJogador(txtJogador.Text);
            c.Jogador = txtJogador.Text;
            c.Posicao = txtPosicao.Text;
            c.NumeroCamisa = txtNumeroCamisa.Text;
            
            ClubeController.Editar(c);
            Limpar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            c = new Clube();
            c = ClubeController.LocalizarPeloJogador(txtJogador.Text);
            txtJogador.Text = c.Jogador;
            txtPosicao.Text = c.Posicao;
            txtNumeroCamisa.Text = c.NumeroCamisa;
            
        }
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            c = new Clube();
            c = ClubeController.LocalizarPeloJogador(txtJogador.Text);
            ClubeController.Excluir(c);
        }




        public void Limpar()
        {
            txtNumeroCamisa.Text = txtPosicao.Text = txtJogador.Text = string.Empty;
            
        }

    }
}