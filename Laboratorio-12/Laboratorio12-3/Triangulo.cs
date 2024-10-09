using System;
using System.Windows.Forms;

namespace Laboratorio12_3
{
    public class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;
         
        public void InputValue(double a, double b, double c)
        {

            ladoA = a;
            ladoB = b;
            ladoC = c;
        }
         
        public double CalcularSemiperimetro()
        {
            double semiperimetro = (ladoA + ladoB + ladoC) / 2;
            return semiperimetro;
        }
         
        public double CalcularArea()
        {
            double s = CalcularSemiperimetro();
            double area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

            return area;
        }
         
        public void LimpiarPantalla(TextBox la,TextBox lb, TextBox lc , TextBox semi , TextBox ar)
        {
            la.Text = ""; lb.Text = ""; lc.Text = ""; semi.Text = ""; ar.Text = "";
        } 
         
        public void Salir() =>
             Environment.Exit(0);
         
    }
}
