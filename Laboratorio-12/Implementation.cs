using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Laboratorio_12
{
    class Implementation
    {

        private float tmp, velo;

        public Implementation()
        {
        }

        public void InputValues(float tiempo, float velocidad)
        { 
            this.tmp = tiempo;
            this.velo = velocidad;
        }
         
        public string ReturnResponse() => ((tmp)/60 * velo).ToString();

        public void CleanDisplay(TextBox txtVelo, TextBox txtTiempo, TextBox txtResponse)
        {
            txtVelo.Text = ""; txtTiempo.Text = ""; txtResponse.Text="";
        }

        public void ExittAplication() =>
            Environment.Exit(0);
        
         

    }
}
