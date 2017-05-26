using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraWeb3
{
    public partial class Calc2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["valor1"] != null && Session["valor2"] != null)
                {
                    //RECUPERA VALORES DA SESSION
                    double valor1 = Convert.ToDouble(Session["valor1"]);
                    double valor2 = Convert.ToDouble(Session["valor2"]);

                    //EFETUAR OS CALCULOS
                    double soma = valor1 + valor2;
                    double sub = valor1 - valor2;
                    double mult = valor1 * valor2;
                    double div = valor1 / valor2;

                    //PREENCHER CAMPOS (EXIBIR VALORES)
                    txtV1A.Text = valor1.ToString();
                    txtV2A.Text = valor2.ToString();
                    txtRA.Text = valor1.ToString() + valor2.ToString();

                    txtV1S.Text = valor1.ToString();
                    txtV2S.Text = valor2.ToString();
                    txtRS.Text = Convert.ToString(valor1 - valor2);

                    txtV1M.Text = valor1.ToString();
                    txtV2M.Text = valor2.ToString();
                    txtRM.Text = Convert.ToString(valor1 * valor2);

                    txtV1D.Text = valor1.ToString();
                    txtV2D.Text = valor2.ToString();
                    txtRD.Text = Convert.ToString(valor1 / valor2);

                }
            }
        }
    }
}