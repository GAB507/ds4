using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12_2
{
    public partial class Form1 : Form
    {
        Implementation Funtion = new Implementation();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProm_Click(object sender, EventArgs e)
        {

            string nota1 = txtNota3.Text;
            string nota2 = txtNota2.Text;
            string nota3 = txtNota1.Text;
               

            float response = Funtion.Calculate(float.Parse(nota1),float.Parse(nota2),float.Parse(nota3));

            txtProm.Text = response.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Funtion.ResetDisplay(txtNota1,txtNota2,txtNota3,txtProm);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Funtion.ExitAp();
        }
    }
}
