using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio20
{
    public partial class Problema_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar si el input es un número entero
            if (int.TryParse(txtDimension.Text, out int n) && n > 0)
            {
                // Crear la matriz en formato HTML
                StringBuilder sb = new StringBuilder();
                sb.Append("<table border='2' cellpadding='10' cellspacing='1'>");

                for (int i = 0; i < n; i++)
                {
                    sb.Append("<tr>");
                    for (int j = 0; j < n; j++)
                    {
                        // Colocar '1' en la diagonal inversa, de lo contrario '0'
                        if (j == (n - i - 1))
                        {
                            sb.Append("<td>1</td>");
                        }
                        else
                        {
                            sb.Append("<td>0</td>");
                        }
                    }
                    sb.Append("</tr>");
                }

                sb.Append("</table>");

                // Asignar la tabla HTML al Label
                lblMatriz.Text = sb.ToString();
            }
            else
            {
                lblMatriz.Text = "Por favor, introduce un número entero positivo para N.";
            }
        }
    }

}