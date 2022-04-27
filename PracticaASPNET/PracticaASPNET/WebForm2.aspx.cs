using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaASPNET
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double PesoEnKilogramos = Convert.ToDouble(TextBox2.Text);
            double AlturaEnMetros = Convert.ToDouble(TextBox1.Text);
            double IMC = PesoEnKilogramos / (AlturaEnMetros * AlturaEnMetros);
            Label1.Text = "IMC " + IMC;
        }
    }
}