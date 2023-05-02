using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace animaldad
{
    public partial class animaldad_xml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Sentencia SQL */
            string sql = "SELECT XML FROM [LM].[pacientes]";
            SqlConnection con = new SqlConnection("Data Source = 'PRIMERO100\\PRIMERO';Initial Catalog=DAM1_DarrenVargas;Integrated Security=SSPI");
            SqlCommand comando = new SqlCommand(sql, con);
            con.Open();
            /*Obtener datos de la BD*/
            SqlDataReader reader = comando.ExecuteReader();
            /*Escribir elemento root en la página de resultado*/
            Response.Write("<Pacientes>");
            /*Recorrer datos de la BD*/
            while (reader.Read())
            {
                /*Escribir datos de la BD*/
                string linea_xml = reader["xml"].ToString();
                Response.Write(linea_xml);
            }
            Response.Write("</Pacientes>");
            con.Close();
            Console.WriteLine(Request.HttpMethod);
            
        }

    }
}