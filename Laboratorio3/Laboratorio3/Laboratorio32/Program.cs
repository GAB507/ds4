using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio32
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculosMatematicos CalculoCirculo = new CalculosMatematicos();
            CalculoCirculo.calculoArea();


        }

        public class CalculosMatematicos
        {
            public void Calcular(int primerNumero, int segundoNumero)
            {
                int operacion = (primerNumero + segundoNumero) * (primerNumero - segundoNumero);
                Console.WriteLine(" el resultado de la operacion (a+b)*(a-b) es : {0} ", operacion);
            }

            public void calculoArea()
            {
                double pi = Math.PI;
                double resultado;
                double radio;
                Console.WriteLine("introduzca el radio del circulo: ");
                radio = Convert.ToDouble(Console.ReadLine());

                resultado = pi * (radio * radio);

                Console.WriteLine("El area del circulo calculado es {0}", resultado);

            }

        }
    }
     
}
