using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace animaldad
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string resultado = "<h2>Animaldad</h2>";
            resultado = resultado + "<table><thead><tr><td>ID</td><td>idAnimal</td><td>Nombre</td><td>Propietario</td><td>Email</td><td>Alta</td><td>Sintomas</td></tr></thead>";
            string sql = "SELECT [idPaciente] ,[IdMascota],[Nombre],[Propietario],[Email],[Alta],[Sintomas] FROM [LM].[pacientes]";
            SqlConnection con = new SqlConnection("Data Source = 'PRIMERO100\\PRIMERO';Initial Catalog=DAM1_DarrenVargas;Integrated Security=SSPI");
            SqlCommand comando = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader datos = comando.ExecuteReader();
            while (datos.Read())
            {
                resultado = resultado + "<tr>";
                resultado = resultado + "<td>" + datos["idPaciente"].ToString() + "</td>";
                resultado = resultado + "<td>" + datos["IdMascota"].ToString() + "</td>";
                resultado = resultado + "<td>" + datos["Nombre"].ToString() + "</td>";
                resultado = resultado + "<td>" + datos["Propietario"].ToString() + "</td>";
                resultado = resultado + "<td>" + datos["Email"].ToString() + "</td>";
                resultado = resultado + "<td>" + datos["Alta"].ToString() + "</td>";
                resultado = resultado + "<td>" + datos["Sintomas"].ToString() + "</td>";
                resultado = resultado + "</tr>";
            }
            resultado = resultado + "</table>";

            Literal1.Text = resultado;
        }
    }
}