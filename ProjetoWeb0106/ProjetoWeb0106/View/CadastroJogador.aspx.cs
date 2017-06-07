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
    public partial class Cadastro : System.Web.UI.Page
    {
        Clube2DBContainer contexto = new Clube2DBContainer();
        Jogador j = new Jogador();


        protected void Page_Load(object sender, EventArgs e)
        {
            var Jogadores = contexto.Jogadores;

            gvJogadores.DataSource = Jogadores.ToList();
            gvJogadores.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            j = new Jogador();
            j.Nome = txtNome.Text;
            j.Posicao = txtPosicao.Text;
            j.Numero = Convert.ToInt32(txtNumero.Text);
            j.ClubeId = 1;

            JogadorController.Adicionar(j);
            Limpar();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            j = JogadorController.LocalizarPeloJogador(txtNome.Text);
            j.Nome = txtNome.Text;
            j.Posicao = txtPosicao.Text;
            j.Numero = Convert.ToInt32(txtNumero.Text);

            JogadorController.Editar(j);
            Limpar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            j = new Jogador();
            j = JogadorController.LocalizarPeloJogador(txtNome.Text);
            txtNome.Text = j.Nome;
            txtPosicao.Text = j.Posicao;
            txtNumero.Text = j.Numero.ToString();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            j = new Jogador();
            j = JogadorController.LocalizarPeloJogador(txtNome.Text);
            JogadorController.Excluir(j);

            Limpar();
        }



        //METODO QUE FAZ A LIMPEZA DA TELA
        public void Limpar()
        {
            txtNumero.Text = txtPosicao.Text = txtNome.Text = string.Empty;
        }
    }
}