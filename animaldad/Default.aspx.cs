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
                string idAnimal = inputTextIdAnimal.Text;
                string mascota = inputTextMascota.Text;
                string email = inputTextEmail.Text;
                string propietario = inputTextPropietario.Text;
                string alta = inputTextAlta.Text;
                string sintomas = inputTextSintomas.Text;

                XmlNode xpaciente = this.xml.CreateElement("Paciente");

                XmlNode xidMascota = createElementPacient("idMascota", idAnimal);
                xpaciente.AppendChild(xidMascota);

                XmlNode xmascota = createElementPacient("Nombre", mascota);
                xpaciente.AppendChild(xmascota);


                XmlNode xpropietario = createElementPacient("Propietario", propietario);
                xpaciente.AppendChild(xpropietario);

                XmlNode xemail = createElementPacient("Email", email);
                xpaciente.AppendChild(xemail);

                XmlNode xalta = createElementPacient("Alta", alta);
                xpaciente.AppendChild(xalta);

                XmlNode xsintomas = createElementPacient("Sintomas", sintomas);
                xpaciente.AppendChild(xsintomas);

                string sql = $"INSERT INTO [LM].[pacientes] ([idMascota],[Nombre],[Email],[Propietario],[Alta],[Sintomas],[xml]) VALUES ({idAnimal},'{mascota}','{email}','{propietario}','{alta}','{sintomas}','{xpaciente.OuterXml}')";
                SqlConnection conn = new SqlConnection("Data Source = 'PRIMERO100\\PRIMERO';Initial Catalog=DAM1_DarrenVargas;Integrated Security=SSPI");
                SqlCommand comand = new SqlCommand(sql, conn);
                conn.Open();
                comand.ExecuteNonQuery();
                conn.Close();
                AlertLiteral.Text = $"<div class='bg-green-500 p-3 text-center text-white rounded-md my-5 font-bold opacity-99'><p>Datos enviados exitosamente!</p></ div > ";
                inputTextMascota.Text = null;
                inputTextAlta.Text = null;
                inputTextEmail.Text = null;
                inputTextPropietario.Text = null;
                inputTextSintomas.Text = null;
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
                AlertLiteral.Text = $"<div class='bg-red-500 p-3 text-center text-white rounded-md my-5 font-bold opacity-99'><p>Error al enviar tus datos</p></ div > ";
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