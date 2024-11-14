using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Threading.Tasks; 
using Laboratorio19_2.Models;

namespace Laboratorio19_2
{
    public partial class _Default : Page
    {
 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private static readonly HttpClient _httpClient = new HttpClient();

        // Método para manejar el evento de clic en el botón "Llamar API 1"
        protected void btnLlamarApi1_Click(object sender, EventArgs e)
        {
            var response = _httpClient.GetAsync("https://localhost:44330/api/Access/HelloWord").Result;
            var data = response.Content.ReadAsStringAsync().Result;
            lblResultado.Text = "Resultado de API 1: " + data+"\n";
        }

        // Método para manejar el evento de clic en el botón "Llamar API 2"
        protected void btnLlamarApi2_Click(object sender, EventArgs e)
        {
            var response = _httpClient.GetAsync("https://tuservidor.com/api/MetodoApi2").Result;
            var data = response.Content.ReadAsStringAsync().Result;
            lblResultado.Text = "Resultado de API 2: " + data;
        }

    }
}