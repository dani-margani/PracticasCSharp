using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica_ASPNET_2
{
    public partial class AltaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Aca creo la variable de conexion y le agrego la cadena de conexion
            var conexion = new SqlConnection(
                //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Usuario\Desktop\PracticasCSharp\Practica ASPNET_2\Practica ASPNET_2\App_Data\PracticaADONETdb.mdf;Integrated Security=True");
                @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = PracticaADONETdb; Integrated Security = True");
            string sql = "INSERT INTO productos (nombre,precio) values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            //Armamos concatenando el comando 
            
            //Response.Write(sql);
            var comando = new SqlCommand(sql, conexion); //Creamos el comando
            conexion.Open();
            comando.ExecuteNonQuery(); // Lo ejecutamos //muy parecido a JavaJDBC
            conexion.Close();
        }
    }
}