using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.CalcularPerimetro();
 
        }
    }

   public class Rectangulo{

    public void CalcularPerimetro(){

     double lados;
     double alto;

     Console.WriteLine("Ingrese el tamaño de los lados:");
     lados = Convert.ToDouble(Console.ReadLine());

     Console.WriteLine("Ingrese el tamaño de la altura:");
     alto = Convert.ToDouble(Console.ReadLine());

     double perimetro = 2*lados+2*alto;

     Console.WriteLine("El perimetro del Rectangulo es {0} ",perimetro);

    }


   }

}
