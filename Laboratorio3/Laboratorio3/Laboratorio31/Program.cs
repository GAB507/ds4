using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio31
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CalculosMatematicos Calculo = new CalculosMatematicos();
            int primeroNumero, segundoNumero;

            Console.WriteLine("Ingrese el primer numero: ");
            primeroNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            Calculo.Calcular(primeroNumero, segundoNumero);

        }

        public class CalculosMatematicos
        {
            public void Calcular(int primerNumero, int segundoNumero)
            {
                int operacion = (primerNumero + segundoNumero) * (primerNumero - segundoNumero);
                Console.WriteLine(" el resultado de la operacion (a+b)*(a-b) es : {0} ", operacion);
            }

        }

    }
     
 }
