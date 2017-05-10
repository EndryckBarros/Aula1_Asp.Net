using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraWeb2
{
    public partial class LayoutCalculadora : System.Web.UI.Page
    {
        public int valor1 { get; set; }
        public int valor2 { get; set; }
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        protected void btnMais_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txtDisplay.Text);
            txtDisplay.Text = string.Empty;
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            int result = 0;
            result = valor1 + int.Parse(txtDisplay.Text);
            txtDisplay.Text = result.ToString();

        }
    }
}