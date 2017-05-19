using CalculadoraWeb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraWeb3
{
    public partial class Calc1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMais_Click(object sender, EventArgs e)
        {
            //Calculo calc = new Calculo();
            //calc.Valor1 = Convert.ToInt32(txtVal1.Text);
            //calc.Valor2 = Convert.ToInt32(txtVal2.Text);

            //calc.Resultado = calc.Valor1 + calc.Valor2;
            //lblResult2.Text = calc.Resultado.ToString();

            //ARMEZANANDO NA VIEWSTATE - VETOR
            ViewState["valor1"] = txtVal1.Text;
            ViewState["valor2"] = txtVal2.Text;

            //RECUPERANDO VIEWSTATE
            double result = Convert.ToDouble(ViewState["valor1"]) + Convert.ToDouble(ViewState["valor2"]);
            lblResult2.Text = result.ToString();
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            //ENVIAR INFORMAÇÃO PARA OUTRA PAGINA - ARMAZENAMENTO NA SESSION
            Session["valor1"] = txtVal1.Text;
            Session["valor2"] = txtVal2.Text;

            Response.Redirect("~/Calc2.aspx");
        }
    }
}