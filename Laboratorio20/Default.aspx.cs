using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio20
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e) { }


        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar si el input es un número
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                // Crear una tabla de multiplicar en formato HTML
                StringBuilder sb = new StringBuilder();
                sb.Append("<table border='1'><tr><th>Multiplicador</th><th>Resultado</th></tr>");

                for (int i = 1; i <= 25; i++)
                {
                    sb.AppendFormat("<tr><td>{0} x {1}</td><td>{2}</td></tr>", numero, i, numero * i);
                }

                sb.Append("</table>");

                // Asignar la tabla HTML al Label
                lblResultado.Text = sb.ToString();
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa un número válido.";
            }
        }
    }
}