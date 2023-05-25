using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace animaldad
{
    public partial class MostrarNoticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "SELECT [id_articulo],[titulo],[autor],[descripcion],[fecha_publicacion],[enlace]FROM[LM].[articulos]";

            SqlConnection conn = new SqlConnection("Data Source = 'PRIMERO100\\PRIMERO';Initial Catalog=DAM1_DarrenVargas;Integrated Security=SSPI");

            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();

            SqlDataReader reader = comando.ExecuteReader();
            string cod_html = "<table><thead><tr><td>ID</td><td>Titulo</td><td>Autor</td><td>Descripcion</td><td>Link</td><td>Fecha de Publicacion</td></tr></thead>";
            while (reader.Read())
            {
                cod_html = cod_html + "<tr>";
                cod_html = cod_html + "<td>";
                string sid = reader["id_articulo"].ToString();
                cod_html = cod_html + sid;
                cod_html = cod_html + "</td>";
                cod_html = cod_html + "<td>";
                string stit = reader["titulo"].ToString();
                cod_html = cod_html + stit;
                cod_html = cod_html + "</td>";
                cod_html = cod_html + "<td>";
                string sau = reader["autor"].ToString();
                cod_html = cod_html + sau;
                cod_html = cod_html + "</td>";
                cod_html = cod_html + "<td>";
                string sdes = reader["descripcion"].ToString();
                cod_html = cod_html + sdes;
                cod_html = cod_html + "</td>";
                cod_html = cod_html + "<td>";
                string slink = reader["enlace"].ToString();
                cod_html = cod_html + slink;
                cod_html = cod_html + "</td>";
                cod_html = cod_html + "<td>";
                string sfp = reader["fecha_publicacion"].ToString();
                cod_html = cod_html + sfp;
                cod_html = cod_html + "</td></tr>";
            }
            cod_html = cod_html + "</table>";
            Literal1.Text = cod_html;

        }
        protected void eliminarNoticia(object sender, EventArgs e)
        {
            try{ 
                string sql = "DELETE FROM [LM].[articulos] WHERE [id_articulo] = " + NID.Text;

                SqlConnection conn = new SqlConnection("Data Source = 'PRIMERO100\\PRIMERO';Initial Catalog=DAM1_DarrenVargas;Integrated Security=SSPI");

                SqlCommand comando = new SqlCommand(sql, conn);
                conn.Open();
                comando.ExecuteNonQuery(); //para enviar informacion
                conn.Close();
                Alert_MostrarNoticia.Text = $"<div class='bg-green-500 p-3 text-center text-white rounded-md my-5 font-bold opacity-99'><p>Noticia eliminada exitosamente!</p></ div > ";
            }catch (Exception error)
            {
                Alert_MostrarNoticia.Text = $"<div class='bg-red-500 p-3 text-center text-white rounded-md my-5 font-bold opacity-99'><p>Error en el ID</p></ div > ";
            }
            finally
            {
                //Alert_MostrarNoticia.Text = "";
            }
        }

    }
}