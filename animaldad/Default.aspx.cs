using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Xml;

namespace animaldad
{
    public partial class _Default : Page
    {

        XmlDocument xml = new XmlDocument();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string mascota = inputTextMascota.Text;
                string email = inputTextEmail.Text;
                string propietario = inputTextPropietario.Text;
                string alta = inputTextAlta.Text;
                string sintomas = inputTextSintomas.Text;

                XmlNode xpaciente = this.xml.CreateElement("Paciente");

                XmlNode xmascota = createElementPacient("mascota", mascota);
                xpaciente.AppendChild(xmascota);

                XmlNode xemail = createElementPacient("email", email);
                xpaciente.AppendChild(xemail);

                XmlNode xpropietario = createElementPacient("propietario", propietario);
                xpaciente.AppendChild(xpropietario);

                XmlNode xalta = createElementPacient("alta", alta);
                xpaciente.AppendChild(xalta);

                XmlNode xsintomas = createElementPacient("sintomas", sintomas);
                xpaciente.AppendChild(xsintomas);

                string sql = $"INSERT INTO [LM].[pacientes] ([Nombre],[Email],[Propietario],[Alta],[Sintomas],[xml]) VALUES ('{mascota}','{email}','{propietario}','{alta}','{sintomas}','{xpaciente.OuterXml}')";
                SqlConnection conn = new SqlConnection("Data Source = 'PRIMERO100\\PRIMERO';Initial Catalog=DAM1_DarrenVargas;Integrated Security=SSPI");
                SqlCommand comand = new SqlCommand(sql, conn);
                conn.Open();
                comand.ExecuteNonQuery();
                conn.Close();
                AlertLiteral.Text = $"<div class='alert alert-success' style='margin-top:10px;'><p>Datos enviados exitosamente!</p></ div > ";
                inputTextMascota.Text = null;
                inputTextAlta.Text = null;
                inputTextEmail.Text = null;
                inputTextPropietario.Text = null;
                inputTextSintomas.Text = null;
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
                AlertLiteral.Text = $"<div class='alert alert-danger'><p>Error al enviar tus datos</p></ div > ";
            }


        }
        private XmlNode createElementPacient(string element,string content)
        {
            XmlNode xelement = this.xml.CreateElement(element);
            xelement.InnerText = content;
            return xelement;
        }
    }
}