using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaASPNET
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 

            if (!Page.IsPostBack)
            {
                Response.Write("Primera carga de pagina " + DateTime.Now);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string nombre = TextBox1.Text;
            //Label1.Text = "Hola" + nombre;
            Session["nombre"] = TextBox1.Text;
            Response.Redirect("WebForm3.aspx");
        }
    }
}