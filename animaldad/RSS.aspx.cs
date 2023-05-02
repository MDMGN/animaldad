using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace animaldad
{
    public partial class RSS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write($"<rss version='2.0'>");
            /*Sentencia SQL */
            string sql = "SELECT * FROM [LM].[articulos]";
            SqlConnection con = new SqlConnection("Data Source = 'PRIMERO100\\PRIMERO';Initial Catalog=DAM1_DarrenVargas;Integrated Security=SSPI");
            SqlCommand comando = new SqlCommand(sql, con);
            con.Open();
            /*Obtener datos de la BD*/
            SqlDataReader reader = comando.ExecuteReader();
            /*Escribir elemento root en la página de resultado*/
            Response.Write("<channel><title>Notcias Darren</title><link>https://google.com</link><description>dswdasdasd</description>");
            string title, description, fecha, author, link;
            while (reader.Read())
            {
                Response.Write("<item>");
                title = reader["titulo"].ToString();
                author = reader["autor"].ToString();
                description = reader["descripcion"].ToString();
                fecha = reader["fecha_publicacion"].ToString();
                link = reader["enlace"].ToString();
                Response.Write($"<title>{title}</title>");
                Response.Write($"<author>{author}</author>");
                Response.Write($"<description>{description}</description>");
                Response.Write($"<link>{link}</link>");
                Response.Write($"<date>{fecha}</date>");
                Response.Write("</item>");
            }
            Response.Write("</channel>");
            Response.Write("</rss>");
            con.Close();
        }
    }
}