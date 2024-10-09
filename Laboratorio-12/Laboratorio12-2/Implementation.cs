using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio12_2
{
    class Implementation
    {

        public Implementation()
        {

        }

         
        public float Calculate(float nota1,float nota2,float nota3)
        {
            return (nota1 + nota2 + nota3) / 3.0f;
        }

        public void ResetDisplay(TextBox n1,TextBox n2, TextBox n3 , TextBox response)
        {
            n1.Text = ""; n2.Text = ""; n3.Text = "";
            response.Text = "";
        }

        public void ExitAp() => Environment.Exit(0);

    }
}
