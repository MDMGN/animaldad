using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace animaldad
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string title = Title_I.Text;
                string author = Author_I.Text;
                string description = Description_I.Text;
                string date = Date_I.Text;
                string link = Link_I.Text;
                string sql = $"INSERT INTO [LM].[articulos] ([titulo],[autor],[descripcion],[fecha_publicacion],[enlace]) VALUES ('{title}','{author}','{description}','{date}','{link}')";
                SqlConnection conn = new SqlConnection("Data Source = 'PRIMERO100\\PRIMERO';Initial Catalog=DAM1_DarrenVargas;Integrated Security=SSPI");
                SqlCommand comand = new SqlCommand(sql, conn);
                conn.Open();
                comand.ExecuteNonQuery();
                conn.Close();
                Alert_InsertNoticia.Text = $"<div class='bg-green-500 p-3 text-center text-white rounded-md my-5 font-bold opacity-99'><p>Datos enviados exitosamente!</p></ div > ";
                Title_I.Text = null;
                Author_I.Text = null;
                Description_I.Text = null;
                Date_I.Text = null;
                Link_I.Text = null;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                Alert_InsertNoticia.Text = $"<div class='bg-red-500 p-3 text-center text-white rounded-md my-5 font-bold opacity-99'><p>Error al enviar tus datos</p></ div > ";
            }
        }
    }
}