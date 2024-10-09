using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12_3
{
    public partial class Form1 : Form
    {

        Triangulo tr = new Triangulo();

        public Form1()
        {
            InitializeComponent();
        }


        private bool Rellena()
        {
            double ladoA = double.Parse(txtLadoA.Text);
            double ladoB = double.Parse(txtLadoB.Text);
            double ladoC = double.Parse(txtLadoC.Text);


            if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
            {
                tr.InputValue(ladoA, ladoB, ladoC);
                return true;
            }
            else
                MessageBox.Show("por favor introduzca lados correctos!");

            return false;
        }

        private void BtnSemi_Click(object sender, EventArgs e)
        {
            var validate =  Rellena();
            double result = tr.CalcularSemiperimetro();

            if(validate)
            txtSemi.Text = result.ToString();
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
           var validate = Rellena();
            double result = tr.CalcularArea();
            
            if(validate)
            txtArea.Text = result.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            tr.LimpiarPantalla(txtArea,txtLadoA,txtLadoB,txtLadoC,txtSemi);
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            tr.Salir();
        }
    }
}
