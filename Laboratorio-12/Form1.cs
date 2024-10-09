using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12
{
    public partial class Form1 : Form
    {
        Implementation Funtion = new Implementation();
        public Form1()
        {
            InitializeComponent();  
        }

        private void BtnCalculo_Click(object sender, EventArgs e)
        {
            float tiempo = float.Parse(txtTiempo.Text);
            float velo = float.Parse(txtVelocidad.Text);
            Funtion.InputValues(tiempo,velo);

            txtResponse.Text = Funtion.ReturnResponse();

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Funtion.CleanDisplay(txtVelocidad,txtTiempo,txtResponse);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Funtion.ExittAplication();
        }
    }
}
